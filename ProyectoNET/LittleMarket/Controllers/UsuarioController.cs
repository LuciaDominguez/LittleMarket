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
        public IEnumerable<Usuario> GetAll()
        {
            List<Usuario> usuarios = dbContext.Usuario.Where(Usuario => Usuario.Activo == false).ToList();

            //LINQ
            //var students = dbContext.Usuario.Where(Usuario => Usuario.Activo == false);

            return usuarios;
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
    }
}
