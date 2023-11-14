using Microsoft.AspNetCore.Mvc;
using SecondHand.Application.Dtos;
using SecondHand.Application.Interfaces;

namespace SecondHand.Infrastructure.Controllers
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
    }
}