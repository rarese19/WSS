using Microsoft.AspNetCore.Mvc;
using WSS.Models.DTOs.MagazinDTOs;
using WSS.Models.Responses;
using WSS.Services.MagazinServices;

namespace WSS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MagazinController : Controller
    {
        private readonly IMagazinServices _magazinServices;

        public MagazinController(IMagazinServices magazinServices)
        {
            _magazinServices = magazinServices;
        }

        [HttpPost("addMagazin")]
        public async Task<IActionResult> Create([FromBody] MagazinDTO magazin)
        {
            try
            {
                await _magazinServices.MagazinCreate(magazin);
                return Ok();
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

        [HttpGet("allMagazin")]
        public async Task<IActionResult> GetAllMagazin()
        {
            try
            {
                return Ok(await _magazinServices.GetAllMagazin());
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

        [HttpDelete("deleteMagazin")]
        public IActionResult DeleteMagazin(Guid id)
        {
            try
            {
                return Ok(_magazinServices.Delete(id));
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

        [HttpPatch("updateMagazin")]
        public IActionResult UpdateMagazin(MagazinUpdateDTO magazin)
        {
            try
            {
                _magazinServices.Update(magazin);
                return Ok();
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

        [HttpGet("magazin/regiune")]
        public IActionResult MagazinRegiune(string regiune)
        {
            try
            {
                return Ok(_magazinServices.MagazineDinRegiuni(regiune));
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
    }
}
