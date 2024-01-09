using Microsoft.AspNetCore.Identity;
using PROIECT.Data;

namespace PROIECT.Helpers.Seeders
{
    public class RoleSeeder
    {
        private readonly Context _dbContext;

        public RoleSeeder(Context dbContext)
        {
            _dbContext = dbContext;
        }

        public void SeedInitialRoles()
        {
            if (!_dbContext.Roles.Any())
            {
                var roles = new List<IdentityRole<Guid>>()
                {
                    new IdentityRole<Guid>()
                    {
                        Id = new Guid("84dbce55263243e48100a49135e91b18"),
                        Name = "Admin",
                        NormalizedName = "Admin".ToUpper()
                    },
                    new IdentityRole<Guid>()
                    {
                        Id = new Guid("e734e372ba464cdfb8e57a8bf943b6b5"),
                        Name = "User",
                        NormalizedName = "User".ToUpper()
                    }
                };

                _dbContext.AddRange(roles);
                _dbContext.SaveChanges();
            }
        }
    }
}
