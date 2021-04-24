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
    public class CategoriaController : Controller
    {
        private LittleMarketBDContext dbContext;

        public CategoriaController(LittleMarketBDContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // GET: api/<CategoriaController>
        [HttpGet]
        public IActionResult GetALL()
        {
            try
            {
                var Categoria = dbContext.Categoria
                        .ToList();

                CategoriaCore categoriasCore = new CategoriaCore(dbContext);

                return Ok(categoriasCore.GetAll());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public IActionResult Create([FromBody] Categoria categoria)
        {
            try
            {
                CategoriaCore categoriasCore = new CategoriaCore(dbContext);

                categoriasCore.Create(categoria);
                return Ok("Categoria Agregado Exitosamente");
            }
            catch (Exception ex)
            {
                return StatusCode((int)System.Net.HttpStatusCode.InternalServerError, ex);
            }
        }

        // GET api/<CategoriaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
    }
}
