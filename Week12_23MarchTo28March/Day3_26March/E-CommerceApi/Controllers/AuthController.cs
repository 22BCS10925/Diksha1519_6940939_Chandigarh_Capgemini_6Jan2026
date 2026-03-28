using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using E_CommerceApi.Data;
using E_CommerceApi.Models;
using E_CommerceApi.DTO;
using AutoMapper;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;
    private readonly IConfiguration _config;

    public AuthController(AppDbContext context, IMapper mapper, IConfiguration config)
    {
        _context = context;
        _mapper = mapper;
        _config = config;
    }

    // ✅ Register
    [HttpPost("register")]
    public IActionResult Register(RegisterDTO dto)
    {
        var user = _mapper.Map<User>(dto);

        _context.Users.Add(user);
        _context.SaveChanges();

        return Ok("User Registered");
    }

    // ✅ Login
    [HttpPost("login")]
    public IActionResult Login(LoginDTO dto)
    {
        var user = _context.Users
            .FirstOrDefault(x => x.Email == dto.Email && x.Password == dto.Password);

        if (user == null)
            return Unauthorized("Invalid credentials");

        var token = GenerateToken(user);

        return Ok(new { token });
    }

    // ✅ JWT Token
    private string GenerateToken(User user)
    {
        var claims = new[]
        {
            new Claim(ClaimTypes.Name, user.Email)
        };

        var key = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(_config["Jwt:Key"])
        );

        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            issuer: _config["Jwt:Issuer"],
            audience: _config["Jwt:Audience"],
            claims: claims,
            expires: DateTime.Now.AddMinutes(60),
            signingCredentials: creds
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }

    // ✅ Protected API
    [Authorize]
    [HttpGet("profile")]
    public IActionResult Profile()
    {
        var email = User.Identity.Name;

        var user = _context.Users.FirstOrDefault(x => x.Email == email);

        var result = _mapper.Map<UserDTO>(user);

        return Ok(result);
    }
}