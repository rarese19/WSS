using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using PROIECT.Models;
using WSS.Models.DTOs.UserDTOs;
using WSS.Models.Responses;
using WSS.Repositories.UserRepository;

namespace WSS.Services.UserServices
{
    public class UserServices: IUserServices
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public UserServices(IUserRepository userRepository,
                            IMapper mapper,
                            UserManager<User> userManager,
                            SignInManager<User> signInManager)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<UserDTO> GetUserById(Guid id)
        {
            var user = await _userRepository.GetUserById(id);
            if (user == null) throw new Exception("User not found");
            return _mapper.Map<UserDTO>(user);
        }

        public async Task<UserDTO> Update(UserUpdateDTO user)
        {
            var existingUser = await _userRepository.GetUserById(user.Id);

            if (existingUser == null)
            {
                throw new Exception("User not found");
            }

            var hasher = new PasswordHasher<User>();
            if (user.UserName != null) existingUser.UserName = user.UserName;
            if (user.Email != null) existingUser.Email = user.Email;
            if (user.Password != null) existingUser.PasswordHash = hasher.HashPassword(null, user.Password);

            await _userRepository.Update(existingUser);
            return _mapper.Map<UserDTO>(existingUser);
        }

        public async Task Delete(Guid userId)
        {
            await _userRepository.Delete(userId);
        }

        public async Task<Guid> Login(UserLoginDTO userLoginDTO)
        {
            var user = await _userManager.FindByEmailAsync(userLoginDTO.Email);

            var result = await _signInManager.CheckPasswordSignInAsync(user, userLoginDTO.Password, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, isPersistent: true);

                return user.Id;
            }

            throw new Exception("Wrong Password");
        }

        public async Task Logout()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<Error> SignUp(UserSignUpDTO signUpDto)
        {
            var existsUser = await _userManager.FindByEmailAsync(signUpDto.Email);

            if (existsUser != null)
                throw new Exception("An account with this email already exists");

            var user = _mapper.Map<User>(signUpDto);
       
            var result = await _userManager.CreateAsync(user);
            
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "User");
           
                return new Error()
                {
                    Cod = 200,
                    Message = "Register was successful"
                };
            }
            throw new Exception(result.Errors.First().Description);
        }
    }
}
