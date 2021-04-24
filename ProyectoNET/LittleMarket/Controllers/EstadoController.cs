using LittleMarket.Classes.Core;
using LittleMarket.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleMarket.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EstadoController : Controller
    {

        private LittleMarketBDContext dbContext;

        public EstadoController(LittleMarketBDContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // GET: api/<EstadoController>
        [HttpGet]
        public IActionResult GetALL()
        {
            try
            {
                var Estados = dbContext.Estado
                        .ToList();

                EstadoCore estadosCore = new EstadoCore(dbContext);

                return Ok(estadosCore.GetAll());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public IActionResult Create([FromBody] Estado estado)
        {
            try
            {
                EstadoCore estadosCore = new EstadoCore(dbContext);

                estadosCore.Create(estado);
                return Ok("Estado Agregado Exitosamente");
            }
            catch (Exception ex)
            {
                return StatusCode((int)System.Net.HttpStatusCode.InternalServerError, ex);
            }
        }

        // GET api/<EstadoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
    }
}
