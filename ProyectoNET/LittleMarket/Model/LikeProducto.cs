using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleMarket.Model
{
    public class LikeProducto
    {
        public int Id { get; set; }
        public bool Like { get; set; }
        public int Id_Usuario { get; set; }
        public int Id_Producto { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Producto Producto { get; set; }

    }
}
