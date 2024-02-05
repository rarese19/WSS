using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PROIECT.Models;
using WSS.Models;
using WSS.Models.DTOs.UserDTOs;
using WSS.Models.Responses;
using WSS.Services.MailServices;
using WSS.Services.UserServices;

namespace WSS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("_myAllowSpecificOrigins")]
    public class UserController : Controller
    {
        private readonly IUserServices _userServices;
        private readonly UserManager<User> _userManager;
        private readonly IMailServices _mailService;

        public UserController(IUserServices userServices, UserManager<User> userManager, IMailServices mailService)
        {
            _userServices = userServices;
            _userManager = userManager;
            _mailService = mailService;
        }

        [HttpPost("signup")]
        public async Task<IActionResult> SignUp([FromBody] UserSignUpDTO userSignUpDTO)
        {
            try
            {
                await _userServices.SignUp(userSignUpDTO);
                var message = new Message(new string[]
                    {userSignUpDTO.Email}, "Welcome to WSS!", "Welcome To Winter Sports Rentals!");
                _mailService.SendEmail(message);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginDTO userLoginDTO)
        {
            try
            {
                return Ok(await _userServices.Login(userLoginDTO));
            }
            catch (Exception ex)
            {
                return BadRequest(new Error()
                {
                    Cod = 200,
                    Message = ex.Message
                });
            }
        }

        [HttpGet("allUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            try
            {
                return Ok(await _userServices.GetAllUsers());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("delete/id")]
        public async Task<IActionResult> DeleteUser(Guid Id)
        {
            try
            {
                await _userServices.Delete(Id);
                return Ok(new Error()
                {
                    Cod = 200,
                    Message = "User was deleted"
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new Error()
                {
                    Cod = 500,
                    Message = ex.Message
                });
            }
        }

        [HttpPatch("update")]
        public async Task<IActionResult> UpdateUser([FromBody] UserUpdateDTO user)
        {
            try
            {
                return Ok(await _userServices.Update(user));
            }
            catch (Exception ex)
            {
                return BadRequest(new Error()
                {
                    Cod = 500,
                    Message = ex.Message
                });
            }
        }

        [HttpGet("username")]
        public async Task<IActionResult> GetUsername(Guid id)
        {
            try
            {
                return Ok(await _userServices.GetUsername(id));
            }
            catch (Exception ex)
            {
                return BadRequest(new Error()
                {
                    Cod = 400,
                    Message = ex.Message
                });
            }
        }
    }
}
