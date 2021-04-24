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
    public class PaisController : ControllerBase
    {

        private LittleMarketBDContext dbContext;

        public PaisController(LittleMarketBDContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // GET: api/<PaisController>
        [HttpGet]
        public  IActionResult GetALL()
        {
            try
            {
                var Pais = dbContext.Pais

                        // .Select(x => new { nombre = x.Name,apellido = x.ApellidoPaterno})
                        .ToList();
                //var usuarios = (
                //from s in dbContext.Usuario
                //join sSCHOLL in dbcontext.otro
                //where s.Activo == false
                //select s
                //).ToList();

                PaisCore PaisCore = new PaisCore(dbContext);

                return Ok(PaisCore.GetAll());
;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        // POST api/<PaisController>
        [HttpPost]
        public IActionResult Create([FromBody] Pais pais)
        {
            try
            {
                PaisCore PaisCore = new PaisCore(dbContext);

                PaisCore.Create(pais);
                return Ok("Pais Agregado Exitosamente");
            }
            catch (Exception ex)
            {
                return StatusCode((int)System.Net.HttpStatusCode.InternalServerError, ex);
            }
        }

        public IActionResult Delete2( int id)
        {
            try
            {
                PaisCore PaisCore = new PaisCore(dbContext);


                var pais = dbContext.Pais.First(p => p.Id == id);


                dbContext.Pais.Remove(pais);
                dbContext.SaveChanges();

                return Ok("Pais Eliminado Exitosamente");
            }
            catch (Exception ex)
            {
                return StatusCode((int)System.Net.HttpStatusCode.InternalServerError, ex);
            }
        }
        // PUT api/<PaisController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PaisController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
           /* try
            {
                PaisCore PaisCore = new PaisCore(dbContext);


                var pais = dbContext.Pais.First(p => p.Id == id);


                dbContext.Pais.Remove(pais);
                dbContext.SaveChanges();

                return Ok("Pais Eliminado Exitosamente");
            }
            catch (Exception ex)
            {
                return StatusCode((int)System.Net.HttpStatusCode.InternalServerError, ex);
            }*/
        }
    }
}
