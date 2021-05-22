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
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SecurityController : ControllerBase
    {    
        private LittleMarketBDContext dbContext;
        private UserManager<AspNetUsers> UserManager;
        private SignInManager<AspNetUsers> SignInManager;

        public SecurityController(UserManager<AspNetUsers> userManager, SignInManager<AspNetUsers> signInManager, IConfiguration configuration)
        {
            Configuration = configuration;
            UserManager = userManager;
            SignInManager = signInManager;
        }

        public IConfiguration Configuration { get; }

        [HttpPost]
        public async Task<IActionResult> SignUp([FromBody] DatosUsuario usuario)
        {
            try
            {
                //var err = ValidateSignUpModel(signUpModel);

                /*if (err != null)
                    return StatusCode(err.HttpStatusCode, err);*/

                var result = await UserManager.CreateAsync(new AspNetUsers
                {
                    Email = usuario.Correo,
                    UserName = usuario.Nombre
                }, usuario.Contra);

                if (!result.Succeeded)
                    return StatusCode((int)HttpStatusCode.InternalServerError, "User create failed");

                return Ok("User create successful");
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

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

                var user = await UserManager.FindByEmailAsync(usuario.Correo.ToUpper());
                var userUN = await UserManager.FindByNameAsync(usuario.Nombre.ToUpper());

                if (user == null)
                    return StatusCode(404);

                var result = await UserManager.CheckPasswordAsync(user, usuario.Contra);

                if (!result)
                    return StatusCode((int)HttpStatusCode.NotFound);

                var keyStr = Configuration.GetValue<string>("SecretKey");
                var key = Encoding.ASCII.GetBytes(keyStr);

                var claims = new ClaimsIdentity(new[] {
                    new Claim( ClaimTypes.NameIdentifier, usuario.Id),
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

                return Ok(tokenHandler.WriteToken(createdToken));
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
