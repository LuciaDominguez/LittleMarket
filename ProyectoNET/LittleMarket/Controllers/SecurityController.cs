using LittleMarket.Model;
using LittleMarket.Model.ModelView;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace LittleMarket.Controllers
{
    public class SecurityController : ControllerBase
    {
        private LittleMarketBDContext dbContext;
        private UserManager<Usuario> UserManager;
        private SignInManager<Usuario> SignInManager;

        public SecurityController(UserManager<Usuario> userManager, SignInManager<Usuario> signInManager, IConfiguration configuration)
        {
            Configuration = configuration;
            UserManager = userManager;
            SignInManager = signInManager;
        }

        public IConfiguration Configuration { get; }

        [HttpPost]
        public async Task<IActionResult> Login ([FromBody] DatosUsuario usuario)
        {
            try
            {
                /*var err = ValidateLoginModel(usuario);

                if(err!=null)
                {
                    return StatusCode(err.HttpStatusCode, err);
                }*/

                var user = await UserManager.FindByEmailAsync(usuario.Correo);

                if (user == null)
                    return StatusCode(404);

                var result = await UserManager.CheckPasswordAsync(user, usuario.Contra);

                if (!result)
                    return StatusCode((int)HttpStatusCode.NotFound);

                var keyStr = Configuration.GetValue<string>("SecretKey");
                var key = Encoding.ASCII.GetBytes(keyStr);

                var claims = new ClaimsIdentity(new[] {
                    new Claim( ClaimTypes.NameIdentifier, usuario.Id.ToString()),
                    new Claim( ClaimTypes.Name, usuario.Nombre)
                });

                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = claims,
                    Expires = DateTime.UtcNow.AddDays(1),
                    SigningCredentials = new SigningCredentials ( new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature )
                };

                var tokenHandler = new JwtSecurityTokenHandler();

                var createdToken = tokenHandler.CreateToken(tokenDescriptor);

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
