using System;
using System.Collections.Generic;
using System.Linq;
using LittleMarket.Model;
using System.Threading.Tasks;

namespace LittleMarket.Classes.Core
{
    public class PaisCore
    {
        LittleMarketBDContext dbContext;
        public PaisCore(LittleMarketBDContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Pais> GetAll()
        {
            try
            {
                //LinQ
                //Funciones
                //Lenguaje
                //SELECT * FROM Usuario
                var Pais =
                    (from u in dbContext.Pais
                  
                     select u
                    ).ToList();

                return Pais;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Create(Pais Pais)
        {
            try
            {
                bool validarUsuario = Validate(Pais);

                if (validarUsuario)
                {

                    dbContext.Add(Pais);
                    dbContext.SaveChanges();

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void Delete(Pais Pais)
        {
            try
            {
                bool validarUsuario = Validate(Pais);

                if (validarUsuario)
                {

                    dbContext.Add(Pais);
                    dbContext.SaveChanges();

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Validate(Pais Pais)
        {

            try
            {
                if (String.IsNullOrEmpty(Pais.Nombre) )
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
