using System;
using LittleMarket.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleMarket.Classes.Core
{
    public class DireccionCore
    {
        LittleMarketBDContext dbContext;
        public DireccionCore(LittleMarketBDContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Direccion direccion)
        {
            try
            {
                bool validarDireccion = Validate(direccion);

                if (validarDireccion)
                {

                    dbContext.Add(direccion);
                    dbContext.SaveChanges();

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Validate(Direccion Direccion)
        {

            try
            {
                if (String.IsNullOrEmpty(Direccion.Calle) || String.IsNullOrEmpty(Direccion.CodigoPostal)  || String.IsNullOrEmpty(Direccion.Numero) || String.IsNullOrEmpty(Direccion.Departamento)
                   )
                {

                    return false;
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
