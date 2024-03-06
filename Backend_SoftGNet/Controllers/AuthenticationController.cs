using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Backend_SoftGNet.Data;
using Backend_SoftGNet.Service;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Backend_SoftGNet.Services;

namespace Backend_SoftGNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly dataContext _context;
        public AuthenticationController(dataContext context) { _context = context; }

        [HttpPost("login")]
        public IActionResult Login([FromBody] Login user)
        {
            if (user is null) return BadRequest("Usuairo Invalido");
            var res = _context.Users.Where(x => x.User_Email == user.User_Email && x.User_Password == user.Password && x.Active == true).First();

#pragma warning disable CS8604 // Posible argumento de referencia nulo
            if (res != null)
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Backend_SoftGNet.Services.ConfigurationManager.AppSetting["JWT:Secret"]));
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                var tokeOptions = new JwtSecurityToken(
                    issuer: Backend_SoftGNet.Services.ConfigurationManager.AppSetting["JWT:ValidIssuer"],
                    audience: Backend_SoftGNet.Services.ConfigurationManager.AppSetting["JWT:ValidAudience"],
                    claims: new List<Claim>(),
                    expires: DateTime.Now.AddHours(24),
                    signingCredentials: signinCredentials
                );
                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                return Ok(new
                {
                    User = res.User_Name,
                    Usua_Id = res.Id,
                    RolUsu_Id = res.Role_Id,
                    Token = tokenString
                });
            }
            return Unauthorized();
#pragma warning restore CS8604 // Posible argumento de referencia nulo
        }
    }
}
