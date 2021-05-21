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
    public class PedidoController : ControllerBase
    {

        private LittleMarketBDContext dbContext;

        public PedidoController(LittleMarketBDContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // GET: api/<PedidoController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PedidoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PedidoController>
        [HttpPost]
        [Authorize]
        public IActionResult Create([FromBody] Pedido pedido)
        {
            try
            {
                PedidoCore pedidoCore = new PedidoCore(dbContext);





                pedidoCore.Create(pedido);
                return Ok("Usuario Agregado Exitosamente");
            }
            catch (Exception ex)
            {
                return StatusCode((int)System.Net.HttpStatusCode.InternalServerError, ex);
            }
        }

        // PUT api/<PedidoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PedidoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
