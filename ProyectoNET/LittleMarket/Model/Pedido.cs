using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleMarket.Model
{
    public class Pedido
    {
        public int Id { get; set; }
        public string LinkVideo { get; set; }
        public int Id_Usuario { get; set; }
        public int Id_Producto { get; set; }
        public int Cantidad { get; set; }
        public int TotalAPagar { get; set; }
        public int Id_Direccion { get; set; }
        public DateTime FechaDePedido { get; set; }
        public DateTime FechaDeEntrega { get; set; }
        public bool PedidoRecibido { get; set; }
        public string Comentarios { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Producto Producto { get; set; }
        public virtual Direccion Direccion { get; set; }







    }
}
