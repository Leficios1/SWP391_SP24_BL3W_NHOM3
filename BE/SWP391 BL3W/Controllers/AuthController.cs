using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SWP391_BL3W.DTO.Request;
using SWP391_BL3W.Services.Interface;

namespace SWP391_BL3W.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(AuthRequestDTO dto)
        {
            var result = await _authService.LoginAccount(dto);
            return Ok(result);
        }
        [HttpGet("login/get-user-by-token/{token}")]
        public async Task<IActionResult> GetUserByToken([FromRoute] string token)
        {
            var result = await _authService.GetUserByToken(token);
            return Ok(result);
        }
        [Authorize(Roles = "1, 2")]
        [HttpGet("test")]
        public async Task<IActionResult> HelloWord()
        {
            return Ok("Completed to authorize");
        }
    }
}
