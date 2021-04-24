using LittleMarket.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleMarket.Classes.Core
{
    public class ProductoCore
    {
        LittleMarketBDContext dbContext;
        public ProductoCore(LittleMarketBDContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Producto> GetAll()
        {
            try
            {
                var productos =
                    (from u in dbContext.Producto
                     select u
                    ).ToList();

                return productos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Create(Producto producto)
        {
            try
            {
                bool validarProducto = Validate(producto);

                if (validarProducto)
                {

                    dbContext.Add(producto);
                    dbContext.SaveChanges();

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Validate(Producto producto)
        {
            try
            {
                if (String.IsNullOrEmpty(producto.Nombre))
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
