using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PROIECT.Models;

namespace WSS.Repositories.UserRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<User> _userManager;

        public UserRepository(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        public async Task<User>? GetUserById(Guid id)
        {
            return await _userManager.FindByIdAsync(id.ToString());
        }
        public async Task CreateAsync(User user)
        {
            var result = await _userManager.CreateAsync(user);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "User");
                return;
            }
        }

        public async Task Delete(Guid userId)
        {
            var existingUser = await GetUserById(userId);

            if (existingUser != null)
            {
                await _userManager.DeleteAsync(existingUser);
            }
        }

        public async Task Update(User user)
        {
            user.SecurityStamp = Guid.NewGuid().ToString();
            await _userManager.UpdateAsync(user);
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await _userManager.Users.ToListAsync();
        }

        public async Task<string> GetUsername(User user)
        {
            return await _userManager.GetUserNameAsync(user);
        }
    }
}
