using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WSS.Models.DTOs.ProdusDTOs;
using WSS.Models.Responses;
using WSS.Services.ProdusServices;

namespace WSS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("_myAllowSpecificOrigins")]
    public class ProdusController : ControllerBase
    {
        private readonly IProdusServices _produsServices;

        public ProdusController(IProdusServices produsServices)
        {
            _produsServices = produsServices;
        }

        [Authorize]
        [HttpPost("addProdus")]
        public async Task<IActionResult> Create([FromBody] ProdusDTO produs)
        {
            try
            {
                await _produsServices.ProdusCreate(produs);
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

        [HttpGet("getAllProdus")]
        public async Task<IActionResult> GetAllProdus()
        {
            try
            {
                return Ok(await _produsServices.GetAllProduse());
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

        [Authorize]
        [HttpGet("getAllProdusInfo")]
        public async Task<IActionResult> GetAllProdusInfo()
        {
            try
            {
                return Ok(await _produsServices.GetAllProduseInfo());
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

        [Authorize]
        [HttpDelete("deleteProdus")]
        public IActionResult DeleteProdus(Guid id)
        {
            try
            {
                return Ok(_produsServices.Delete(id));
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

        [Authorize]
        [HttpPatch("updateProdus")]
        public IActionResult Update(ProdusUpdateDTO produs)
        {
            try
            {
                _produsServices.Update(produs);
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
