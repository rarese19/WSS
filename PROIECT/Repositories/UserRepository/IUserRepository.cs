﻿using PROIECT.Models;

namespace WSS.Repositories.UserRepository
{
    public interface IUserRepository
    {
        Task<User>? GetUserById(Guid id);
        Task CreateAsync(User user);
        Task Update(User user);
        Task Delete(Guid userId);
        Task<List<User>> GetUsersAsync();
        Task<string> GetUsername(User user);
    }
}
