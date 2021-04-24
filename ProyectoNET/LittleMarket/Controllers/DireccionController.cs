using Microsoft.AspNetCore.Mvc;
using LittleMarket.Classes.Core;
using LittleMarket.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LittleMarket.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DireccionController : ControllerBase
    {


        private LittleMarketBDContext dbContext;

        public DireccionController(LittleMarketBDContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // GET: api/<DireccionController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DireccionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DireccionController>
        [HttpPost]
        public IActionResult Create([FromBody] Direccion direccion)
        {
            try
            {
                DireccionCore direccionCore = new DireccionCore(dbContext);

                direccionCore.Create(direccion);

                return Ok("Direccion Agregado Exitosamente");
            }
            catch (Exception ex)
            {
                return StatusCode((int)System.Net.HttpStatusCode.InternalServerError, ex);
            }
        }

        // PUT api/<DireccionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DireccionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
