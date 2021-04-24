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
    public class CiudadController : Controller
    {
        private LittleMarketBDContext dbContext;

        public CiudadController(LittleMarketBDContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // GET: api/<CiudadController>
        [HttpGet]
        public IActionResult GetALL()
        {
            try
            {
                var Ciudades = dbContext.Ciudad
                        .ToList();

                CiudadCore ciudadesCore = new CiudadCore(dbContext);

                return Ok(ciudadesCore.GetAll());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public IActionResult Create([FromBody] Ciudad ciudad)
        {
            try
            {
                CiudadCore ciudadesCore = new CiudadCore(dbContext);

                ciudadesCore.Create(ciudad);
                return Ok("Ciudad Agregado Exitosamente");
            }
            catch (Exception ex)
            {
                return StatusCode((int)System.Net.HttpStatusCode.InternalServerError, ex);
            }
        }

        // GET api/<CiudadController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
    }
}
