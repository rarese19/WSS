﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WSS.Models.DTOs.MagazinDTOs;
using WSS.Models.Responses;
using WSS.Services.MagazinServices;

namespace WSS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("_myAllowSpecificOrigins")]
    public class MagazinController : Controller
    {
        private readonly IMagazinServices _magazinServices;

        public MagazinController(IMagazinServices magazinServices)
        {
            _magazinServices = magazinServices;
        }

        [Authorize]
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
        public IActionResult GetAllMagazin()
        {
            try
            {
                return Ok(_magazinServices.GetAllMagazin());
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
        [HttpGet("allMagazinInfo")]
        public IActionResult GetAllMagazinInfo()
        {
            try
            {
                return Ok(_magazinServices.GetAllMagazinInfo());
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

        [Authorize]
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
