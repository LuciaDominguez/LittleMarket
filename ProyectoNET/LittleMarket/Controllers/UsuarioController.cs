using LittleMarket.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LittleMarket.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private LittleMarketBDContext dbContext;

        public UsuarioController(LittleMarketBDContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // GET: api/<UsuarioController>
        [HttpGet]

        IActionResult GetALL()
        public /*IEnumerable<Usuario>  GetAll() */ IActionResult GetALL()
        {
            try { 
            var usuarios = dbContext.Usuario
                    .Where(Usuario => Usuario.Activo == true)
                   // .Select(x => new { nombre = x.Name,apellido = x.ApellidoPaterno})
                    .ToList();
            //var usuarios = (
            //from s in dbContext.Usuario
            //join sSCHOLL in dbcontext.otro
            //where s.Activo == false
            //select s
            //).ToList();

                usuariosCore  usuariosCore = new usuariosCore(dbContext);

                return Ok(usuariosCore.GetAll());


                }
            catch (Exception ex)
            {
                throw StatusCode((int)HttpStatusCode.InternalServerError);
            }

            //LINQ
            //var students = dbContext.Usuario.Where(Usuario => Usuario.Activo == false);

            return usuarios;
        }

        [HttpPost]
        public IActionResult Create()
        {
               try
            {
                  usuariosCore  usuariosCore = new usuariosCore(dbContext);
                 Usuario usuario  = new Usuario
                 {
                     Nombre = "ejemplo",
                     ApellidoMaterno = "a",
                     ApellidoPaterno = "b",
                     Correo ="coso@hotmail.com",
                     Contra ="coso123",
                     Id_Pais =
                     Activo = true
                 }

                 usuariosCore.Create(usuario);
                return Ok("Usuario Agregado Exitosamente");


            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
    }
}
