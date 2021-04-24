using LittleMarket.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleMarket.Classes.Core
{
    public class CategoriaCore
    {
        LittleMarketBDContext dbContext;
        public CategoriaCore(LittleMarketBDContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Categoria> GetAll()
        {
            try
            {
                var categorias =
                    (from u in dbContext.Categoria
                     select u
                    ).ToList();

                return categorias;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Create(Categoria categoria)
        {
            try
            {
                bool validarCategoria = Validate(categoria);

                if (validarCategoria)
                {

                    dbContext.Add(categoria);
                    dbContext.SaveChanges();

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Validate(Categoria categoria)
        {
            try
            {
                if (String.IsNullOrEmpty(categoria.Nombre))
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
