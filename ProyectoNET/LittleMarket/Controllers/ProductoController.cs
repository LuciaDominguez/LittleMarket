using LittleMarket.Classes.Core;
using LittleMarket.Model;
using Microsoft.AspNetCore.Authorization;
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
    public class ProductoController : Controller
    {
        private LittleMarketBDContext dbContext;

        public ProductoController(LittleMarketBDContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // GET: api/<ProductoController>
        [HttpGet]
        public IActionResult GetALL()
        {
            try
            {
                var Producto = dbContext.Producto
                        .ToList();

                ProductoCore productosCore = new ProductoCore(dbContext);

                return Ok(productosCore.GetAll());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public IActionResult Create([FromBody] Producto producto)
        {
            try
            {
                ProductoCore productosCore = new ProductoCore(dbContext);

                productosCore.Create(producto);
                return Ok("Producto Agregado Exitosamente");
            }
            catch (Exception ex)
            {
                return StatusCode((int)System.Net.HttpStatusCode.InternalServerError, ex);
            }
        }

        // GET api/<ProductoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
    }
}
