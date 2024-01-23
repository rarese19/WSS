using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PROIECT.Models;
using WSS.Models.DTOs.UserDTOs;
using WSS.Models.Responses;
using WSS.Services.UserServices;

namespace WSS.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserServices _userServices;
        private readonly UserManager<User> _userManager;

        public UserController(IUserServices userServices, UserManager<User> userManager)
        {
            _userServices = userServices;
            _userManager = userManager;
        }

        [HttpPost("signup")]
        public async Task<IActionResult> SignUp([FromBody] UserSignUpDTO userSignUpDTO)
        {
            try
            {
                return Ok(await _userServices.SignUp(userSignUpDTO));
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
    }
}
