using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using api.Models;

namespace api.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly IConfiguration _config;

    public AuthController(IConfiguration config)
    {
        _config = config;
    }

    [HttpPost("login")]
    public ActionResult<AuthResponse> Login([FromBody] LoginRequest request)
    {
        var expectedUsername = _config["AdminCredentials:Username"];
        var expectedPassword = _config["AdminCredentials:Password"];

        if (request.Username != expectedUsername || request.Password != expectedPassword)
            return Unauthorized(new { message = "Invalid credentials." });

        var token = GenerateJwtToken();
        return Ok(new AuthResponse
        {
            Token = token,
            Name = "Administrator",
            Role = "Admin"
        });
    }

    private string GenerateJwtToken()
    {
        var secret   = _config["Jwt:Secret"]   ?? throw new InvalidOperationException("Jwt:Secret is not configured.");
        var issuer   = _config["Jwt:Issuer"]   ?? "TajRestaurantAPI";
        var audience = _config["Jwt:Audience"] ?? "TajRestaurantClient";
        var expiry   = int.TryParse(_config["Jwt:ExpiryHours"], out var h) ? h : 24;

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret));
        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var claims = new[]
        {
            new Claim(ClaimTypes.Name, "admin"),
            new Claim(ClaimTypes.Role, "Admin"),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

        var token = new JwtSecurityToken(
            issuer: issuer,
            audience: audience,
            claims: claims,
            expires: DateTime.UtcNow.AddHours(expiry),
            signingCredentials: credentials
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
