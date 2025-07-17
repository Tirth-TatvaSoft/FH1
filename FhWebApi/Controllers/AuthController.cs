using FH1Core.RequestModels;
using FH1Core.ResponseModels;
using FH1Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace FhWebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController(IAuthService authservice) : ControllerBase
{
    private readonly IAuthService _authService = authservice;
    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] AuthRequest request)
    {
        ServiceResult<AuthResponse> result = await _authService.Login(request);
        if (!result.Success)
            return Unauthorized(new { message = result.Message });

        return Ok(result.Data);
    }
}
