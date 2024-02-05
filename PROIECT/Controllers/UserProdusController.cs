using FirebaseAdmin.Auth;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WSS.Models.DTOs.UserProdusDTOs;
using WSS.Services.UserProdusServices;

namespace WSS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("_myAllowSpecificOrigins")]
    public class UserProdusController : ControllerBase
    {
        private readonly IUserProdusServices _userProdusService;

        public UserProdusController(IUserProdusServices userProdusService)
        {
            _userProdusService = userProdusService;
        }

        [HttpPost("assign")]
        public async Task<IActionResult> AdaugaProdus([FromBody] UserProdusDTO magazinprodus)
        {
            await _userProdusService.Create(magazinprodus);
            return Ok();
        }

        [HttpGet("produseByUser")]
        public IActionResult ProduseByUser(Guid userId)
        {
            return Ok(_userProdusService.GetProdusByUser(userId));
        } 

        [HttpDelete("delete/${id}")]
        public IActionResult Delete(Guid id)
        {
            _userProdusService.Delete(id);
            return Ok();
        }
    }
}
