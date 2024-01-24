using PROIECT.Models;
using WSS.Models.DTOs.UserDTOs;
using WSS.Models.Responses;

namespace WSS.Services.UserServices
{
    public interface IUserServices
    {
        Task<UserDTO> GetUserById(Guid Id);
        Task<Error> SignUp(UserSignUpDTO signUpDto);
        Task<Guid> Login(UserLoginDTO user);
        Task Logout();
        Task Delete(Guid userId);
        Task<UserDTO> Update(UserUpdateDTO user);
        Task<List<User>> GetAllUsers();
    }
}
