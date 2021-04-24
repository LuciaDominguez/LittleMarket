using System;
using LittleMarket.Model;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleMarket.Classes.Core
{
    public class PedidoCore
    {
        LittleMarketBDContext dbContext;
        public PedidoCore(LittleMarketBDContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Pedido pedido)
        {
            try
            {
                bool validarpedido = Validate(pedido);

                if (validarpedido)
                {

                    dbContext.Add(pedido);
                    dbContext.SaveChanges();

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Validate(Pedido pedido)
        {

            try
            {
                //pendiente validacion
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
