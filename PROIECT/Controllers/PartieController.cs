using Microsoft.AspNetCore.Mvc;
using WSS.Models.DTOs.PartieDTOs;
using WSS.Models.Responses;
using WSS.Repositories.PartieRepository;
using WSS.Services.PartieServices;

namespace WSS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartieController : Controller
    {
        private readonly IPartieServices _partieServices;

        public PartieController(IPartieServices partieServices)
        {
            _partieServices = partieServices;
        }

        [HttpPost("addPartie")]
        public async Task<IActionResult> Create([FromBody] PartieDTO partieDTO)
        {
            try
            {
                await _partieServices.PartieCreate(partieDTO);
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

        [HttpGet("allPartie")]
        public async Task<IActionResult> GetAllPartie()
        {
            try
            {
                return Ok(await _partieServices.GetAllPartie());
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

        [HttpGet("partie/statiune")]
        public IActionResult GetPartieByStatiune(Guid statiuneId)
        {
            try
            {   
                return Ok(_partieServices.GetPartiiByStatiune(statiuneId));
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

        [HttpDelete("deletePartie")]
        public IActionResult DeletePartie(Guid id)
        {
            try
            {
                return Ok(_partieServices.Delete(id));
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

        [HttpPatch("updatePartie")]
        public IActionResult Update(PartieUpdateDTO partie)
        {
            try
            {
                _partieServices.Update(partie);
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
