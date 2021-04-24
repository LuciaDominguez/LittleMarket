using LittleMarket.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleMarket.Classes.Core
{
    public class EstadoCore
    {
        LittleMarketBDContext dbContext;
        public EstadoCore(LittleMarketBDContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Estado> GetAll()
        {
            try
            {
                var estados =
                    (from u in dbContext.Estado
                     select u
                    ).ToList();

                return estados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Create(Estado estado)
        {
            try
            {
                bool validarEstado = Validate(estado);

                if (validarEstado)
                {

                    dbContext.Add(estado);
                    dbContext.SaveChanges();

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Validate(Estado estado)
        {

            try
            {
                if (String.IsNullOrEmpty(estado.Nombre))
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
