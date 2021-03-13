using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleMarket.Model
{
    public class Producto
    {
        public int Id { get; set; }
        public int Precio { get; set; }
        public int CantidadAlmacen { get; set; }
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaDePublicacion { get; set; }
        public bool Activo { get; set; }
        public int Id_Categoria { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual ICollection<Multimedia> Multimedia { get; set; }
        public virtual ICollection<Pedido> Pedido { get; set; }
        public virtual ICollection<Comentario> Comentario { get; set; }
        public virtual ICollection<LikeProducto> LikeProducto { get; set; }

    }
}
