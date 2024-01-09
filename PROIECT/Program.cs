using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PROIECT.Data;
using PROIECT.Helpers.Extensions;
using PROIECT.Helpers.Seeders;
using PROIECT.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<Context>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<User, IdentityRole<Guid>>()
    .AddRoles<IdentityRole<Guid>>()
    .AddEntityFrameworkStores<Context>()
    .AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions>(opt =>
{
    opt.Password.RequireDigit = false;
    opt.Password.RequiredLength = 8;
    opt.User.RequireUniqueEmail = true;
    opt.SignIn.RequireConfirmedAccount = false;
    opt.SignIn.RequireConfirmedEmail = false;
    opt.SignIn.RequireConfirmedPhoneNumber = false;
});

builder.Services.AddRepositories();
builder.Services.AddServices();
builder.Services.AddSeeders();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
SeedData(app);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

void SeedData(IHost app)
{
    var scopedFactory = app.Services.GetService<IServiceScopeFactory>();
    using (var scope = scopedFactory.CreateScope())
    {

        var roleService = scope.ServiceProvider.GetService<RoleSeeder>();
        roleService.SeedInitialRoles();

        var userService = scope.ServiceProvider.GetService<UserSeeder>();
        userService.SeedInitialUsers();

        var userRoleService = scope.ServiceProvider.GetService<UserRoleSeeder>();
        userRoleService.SeedInitialUsersRoles();
    }
}
