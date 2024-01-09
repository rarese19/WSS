using Microsoft.AspNetCore.Identity;
using PROIECT.Data;

namespace PROIECT.Helpers.Seeders
{
    public class UserRoleSeeder
    {
        protected readonly Context _dbContext;

        public UserRoleSeeder(Context DbContext) 
        {
            _dbContext = DbContext;
        }

        public void SeedInitialUsersRoles()
        {
            if (!_dbContext.UserRoles.Any())
            {
                var userRoles = new List<IdentityUserRole<Guid>>() 
                {
                    new IdentityUserRole<Guid>()
                    {
                        RoleId = new Guid("84dbce55263243e48100a49135e91b18"),
                        UserId = new Guid("759a2a6090f34d4ba9ff66cde8f01a8b")
                    },
                    new IdentityUserRole<Guid>()
                    {
                        RoleId = new Guid("e734e372ba464cdfb8e57a8bf943b6b5"),
                        UserId = new Guid("87cb826108fe46438ef049f009cd3cda")
                    },
                    new IdentityUserRole<Guid>()
                    {
                        RoleId = new Guid("e734e372ba464cdfb8e57a8bf943b6b5"),
                        UserId = new Guid("f2533a6cf83241eba7058e7c17123eb2")
                    },
                    new IdentityUserRole<Guid>()
                    {
                        RoleId = new Guid("e734e372ba464cdfb8e57a8bf943b6b5"),
                        UserId = new Guid("49e4f70396b442059c99f727f3d96bbd")
                    }
                };

                _dbContext.AddRange(userRoles);
                _dbContext.SaveChanges();
            };
        }
    }
}
