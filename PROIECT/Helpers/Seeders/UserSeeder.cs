using Microsoft.AspNetCore.Identity;
using PROIECT.Data;
using PROIECT.Models;

namespace PROIECT.Helpers.Seeders
{
    public class UserSeeder
    {
        private readonly Context _dbContext;

        public UserSeeder(Context dbContext)
        {
            _dbContext = dbContext;
        }

        public void SeedInitialUsers()
        {
            if (!_dbContext.Users.Any())
            {
                var hasher = new PasswordHasher<User>();
                var users = new List<User>
                {
                    new User()
                    {
                        Id = new Guid("759a2a6090f34d4ba9ff66cde8f01a8b"),
                        UserName = "Cr0_Nix",
                        Nume = "Papusoi",
                        Prenume = "Rares",
                        NormalizedUserName = "Cr0_Nix".ToUpper(),
                        Email = "rares19@yahoo.com",
                        NormalizedEmail = "rares19@yahoo.com".ToUpper(),
                        PasswordHash = hasher.HashPassword(null, "parolarares"),
                        SecurityStamp = Guid.NewGuid().ToString()
                    },
                    new User()
                    {
                        Id = new Guid("49e4f70396b442059c99f727f3d96bbd"),
                        UserName = "skpha",
                        Nume = "Mincu",
                        NormalizedUserName = "skpha".ToUpper(),
                        Email = "skpha13@yahoo.com",
                        NormalizedEmail = "skpha13@yahoo.com".ToUpper(),
                        PasswordHash = hasher.HashPassword(null, "parolaskpha"),
                        SecurityStamp = Guid.NewGuid().ToString()
                    },
                    new User()
                    {
                        Id = new Guid("f2533a6cf83241eba7058e7c17123eb2"),
                        UserName = "matoka",
                        Nume = "Dogaru",
                        NormalizedUserName = "matoka".ToUpper(),
                        Email = "matoka@yahoo.com",
                        NormalizedEmail = "matoka@yahoo.com".ToUpper(),
                        PasswordHash = hasher.HashPassword(null, "parolamatoka"),
                        SecurityStamp = Guid.NewGuid().ToString()
                    },
                    new User()
                    {
                        Id = new Guid("87cb826108fe46438ef049f009cd3cda"),
                        UserName = "andreidogarel",
                        Nume = "Dogarel",
                        NormalizedUserName = "andreidogarel".ToUpper(),
                        Email = "andreidogarel@yahoo.com",
                        NormalizedEmail = "andreidogarel@yahoo.com".ToUpper(),
                        PasswordHash = hasher.HashPassword(null, "parolagodarel"),
                        SecurityStamp = Guid.NewGuid().ToString()
                    }
                };

                _dbContext.Users.AddRange(users);
                _dbContext.SaveChanges();
            }
        }
    }
}
