using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WSS.Models.DTOs.MagazinProdusDTOs;
using WSS.Services.MagazinProdusServices;

namespace WSS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("_myAllowSpecificOrigins")]
    public class MagazinProdusController : ControllerBase
    {
        private readonly IMagazinProdusService _magazinProdusService;
        
        public MagazinProdusController(IMagazinProdusService magazinProdusService)
        {
            _magazinProdusService = magazinProdusService;
        }

        [HttpPost("assign")]
        public async Task<IActionResult> AdaugaProdus([FromBody] MagazinProdusDTO magazinprodus)
        {
            await _magazinProdusService.Create(magazinprodus);
            return Ok();
        }

        [HttpDelete("delete/${id}")]
        public IActionResult Delete(Guid id)
        {
            _magazinProdusService.Delete(id);
            return Ok();
        }

        [HttpGet("produse-per-magazin")]
        public IActionResult GetProdusPerMagazinBrand()
        {
            return Ok(_magazinProdusService.GetProdusePerMagazinBrand());
        }
    }
}
