using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WSS.Models.DTOs.StatiuneDTOs;
using WSS.Models.Responses;
using WSS.Repositories.StatiuneRepository;
using WSS.Services.StatiuneServices;

namespace WSS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("_myAllowSpecificOrigins")]
    public class StatiuneController: Controller
    {
        private readonly IStatiuneServices _statiuneServices;

        public StatiuneController(IStatiuneServices statiuneRepository)
        {
            _statiuneServices = statiuneRepository;
        }

        [HttpPost("addStatiune")]
        public async Task<IActionResult> Create([FromBody] StatiuneDTO statiuneDTO)
        {
            try
            {
                await _statiuneServices.StatiuneCreate(statiuneDTO);
                return Ok(new Error()
                {
                    Cod = 200,
                    Message = "Statiune creata"
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("allStatiune")]
        public async Task<IActionResult> GetAllStatiune()
        {
            try
            {
                return Ok(await _statiuneServices.GetAllStatiune());
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
        [HttpGet("allStatiuneInfo")]
        public IActionResult GetAllStatiuneInfo()
        {
            try
            {
                return Ok(_statiuneServices.GetAllStatiuneInfo());
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

        [HttpDelete("deleteStatiune")]
        public IActionResult DeleteStatiune(Guid Id)
        {
            try
            {
                return Ok(_statiuneServices.Delete(Id));
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

        [HttpPatch("updateStatiune")]
        public IActionResult Update(StatiuneUpdateDTO statiune)
        {
            try
            {
                _statiuneServices.Update(statiune);
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

        [HttpGet("statiuneByRegiune")]
        public IActionResult GetStatiuneByRegiune(string regiune)
        {
            try
            {
                return Ok(_statiuneServices.GetStatiuneByRegiune(regiune));
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
