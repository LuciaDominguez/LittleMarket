using LittleMarket.Classes.Core;
using LittleMarket.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LittleMarket.Controllers
{
    [Route("api/[controller]/[action]")]
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

        //IActionResult GetALL();
        public /*IEnumerable<Usuario>  GetAll() */ IActionResult GetALL()
        {
            try
            {
                var usuarios = dbContext.AspNetUsers
                        .Where(AspNetUsers => AspNetUsers.Activo == true)
                        .Select(x => new { nombre = x.Nombre,apellido = x.ApellidoPaterno})
                        .ToList();
                //var usuarios = (
                //from s in dbContext.Usuario
                //join sSCHOLL in dbcontext.otro
                //where s.Activo == false
                //select s
                //).ToList();

                UsuarioCore usuariosCore = new UsuarioCore(dbContext);

                return Ok(usuariosCore.GetAll());

                //LINQ
                //var students = dbContext.Usuario.Where(Usuario => Usuario.Activo == false);

                //return (IActionResult)usuarios;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public IActionResult FindByEmail(string email)
        {
            try
            {
                var usuarios = dbContext.AspNetUsers
                        .Where(Usuario => Usuario.Correo == email)
                        .ToList();

                UsuarioCore usuariosCore = new UsuarioCore(dbContext);

                return Ok(usuariosCore.FindByEmail(email));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IActionResult CheckPassword(string correo, string contra)
        {
            try
            {
                var usuarios = dbContext.AspNetUsers
                        .Where(Usuario => Usuario.Contra == contra && Usuario.Correo == correo)
                        .ToList();

                UsuarioCore usuariosCore = new UsuarioCore(dbContext);

                return Ok(usuariosCore.CheckPassword(correo, contra));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public IActionResult Create([FromBody] AspNetUsers usuario)
        {
            try
            {
                UsuarioCore  usuariosCore = new UsuarioCore(dbContext);


            /*Usuario usuario2 = new Usuario
            { 
                    Nombre = "ejemplo",
                    ApellidoMaterno = "a",
                    ApellidoPaterno = "b",
                    Correo = "coso@hotmail.com",
                    Contra = "coso123",
                    Id_Pais = 1,
                    Id_Ciudad =1,
                    Id_Estado =1,
                    UltimaConexion = V,
                    Telefono = "101213134",
                    FechaDeNacimiento = V,
                    FechaDeRegistro = V,
                    Activo = true
            };*/


            usuariosCore.Create(usuario);
            return Ok("Usuario Agregado Exitosamente");
            }
            catch (Exception ex)
            {
                return StatusCode((int)System.Net.HttpStatusCode.InternalServerError, ex);
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
