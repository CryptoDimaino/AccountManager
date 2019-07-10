using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AccountManagerAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AccountManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly Context _Context;
        public TestController(Context Context)
        {
            _Context = Context;
        }

        // GET api/test
        [HttpGet]
        public async Task<IActionResult> GetAccounts()
        {
            try
            {
                return Ok(await _Context.EmailAccounts.ToListAsync());
            }
            catch(Exception ex)
            {
                return StatusCode(500, "Internal Server Error.");
            }
        }

        // GET api/test/games
        [HttpGet("games")]
        public async Task<IActionResult> GetGames()
        {
            try
            {
                return Ok(await _Context.Games.ToListAsync());
            }
            catch(Exception ex)
            {
                return StatusCode(500, "Internal Server Error.");
            }
        }

        // GET api/test/platforms
        [HttpGet("platforms")]
        public async Task<IActionResult> GetPlatforms()
        {
            try
            {
                return Ok(await _Context.Platforms.ToListAsync());
            }
            catch(Exception ex)
            {
                return StatusCode(500, "Internal Server Error.");
            }
        }

        // GET api/test/codes
        [HttpGet("codes")]
        public async Task<IActionResult> GetCodes()
        {
            try
            {
                return Ok(await _Context.Codes.ToListAsync());
            }
            catch(Exception ex)
            {
                return StatusCode(500, "Internal Server Error.");
            }
        }
    }
}
