using Microsoft.AspNetCore.Mvc;
using UserAPI.Dtos;
using UserAPI.Services.Interfaces;

namespace UserAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("Register")]
    public async Task<IActionResult> Register([FromBody] UserDto model)
    {
        var result = await _userService.RegisterUserAsync(model);
        if (!result)
        {
            return BadRequest(new { Message = "User registration failed" });
        }

        return Ok(new { Message = "User registered successfully" });
    }

    [HttpPost("Login")]
    public async Task<IActionResult> Login([FromBody] LoginDto model)
    {
        var token = await _userService.AuthenticateUserAsync(model);
        if (string.IsNullOrWhiteSpace(token))
            return Unauthorized(new { Message = "Invalid credentials" });

        return Ok(new { Token = token });
    }
}