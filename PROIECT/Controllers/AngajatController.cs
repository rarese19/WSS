using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WSS.Models.DTOs.AngajatDTOs;
using WSS.Models.Responses;
using WSS.Services.AngajatServices;

namespace WSS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AngajatController : ControllerBase
    {
        private readonly IAngajatServices _angajatServices;

        public AngajatController(IAngajatServices angajatServices)
        {
            _angajatServices = angajatServices;
        }

        [HttpPost("addAngajat")]
        public async Task<IActionResult> Create([FromBody] AngajatCreateDTO angajatDTO)
        {
            try
            {
                await _angajatServices.AngajatCreate(angajatDTO);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(new Error()
                {
                    Cod = 500,
                    Message = ex.Message
                });
            }
        }

        [HttpGet("getAllAngajat")]
        public async Task<IActionResult> GetAllAngajat()
        {
            try
            {
                return Ok(await _angajatServices.GetAllAngajati());
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

        [HttpGet("angajati/${magazinId}")]
        public IActionResult GetAngajatByMagazin(Guid magazinId)
        {
            try
            {
                return Ok(_angajatServices.GetAngajatiByMagazin(magazinId));
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

        [HttpGet("angajatAllInfo")]
        public async Task<IActionResult> GetAngajatAllInfo()
        {
            try
            {
                return Ok(await _angajatServices.GetAllAngajatInfo());
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

        [HttpDelete("deleteAngajat")]
        public IActionResult DeleteAngajat(Guid id)
        {
            try
            {
                return Ok(_angajatServices.Delete(id));
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

        [HttpPatch("updateAngajat")]
        public IActionResult Update(AngajatUpdateDTO angajat)
        {
            try
            {
                _angajatServices.Update(angajat);
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


    }
}
