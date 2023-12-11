using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SecondHand.Application.Dtos;
using SecondHand.Application.Interfaces;

namespace SecondHand.WebApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthentificationService _authentificationService;

        public AuthController(IAuthentificationService authentificationService)
        {
            _authentificationService = authentificationService;
        }
        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] AuthentificationDto request)
        {
            var result = await _authentificationService.LoginAsync(request.Email, request.Password);
            if (result.ErrorMessage != null)
            {
                return BadRequest(result.ErrorMessage);
            }

            return Ok(result.Token);
        }
        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserRegistrationDto request)
        {
            var result = await _authentificationService.RegisterAsync(request.Email, request.Password, request.Name);
            if (result.ErrorMessage != null)
            {
                return BadRequest(result.ErrorMessage);
            }

            return Ok(result.Token);
        }
        [AllowAnonymous]
        [HttpPost("verify")]
        public async Task<IActionResult> Verify([FromBody] string token)
        {
            var result = await _authentificationService.CheckTokenValidityAsync(token);
            if (!result)
            {
                return BadRequest("Invalid token");
            }

            return Ok("Token is valid");
        }
    }
}