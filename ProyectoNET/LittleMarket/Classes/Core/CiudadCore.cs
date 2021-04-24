using LittleMarket.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleMarket.Classes.Core
{
    public class CiudadCore
    {
        LittleMarketBDContext dbContext;
        public CiudadCore(LittleMarketBDContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Ciudad> GetAll()
        {
            try
            {
                var ciudades =
                    (from u in dbContext.Ciudad
                     select u
                    ).ToList();

                return ciudades;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Create(Ciudad ciudad)
        {
            try
            {
                bool validarCiudad = Validate(ciudad);

                if (validarCiudad)
                {

                    dbContext.Add(ciudad);
                    dbContext.SaveChanges();

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Validate(Ciudad ciudad)
        {

            try
            {
                if (String.IsNullOrEmpty(ciudad.Nombre))
                {

                    return true;
                }
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
