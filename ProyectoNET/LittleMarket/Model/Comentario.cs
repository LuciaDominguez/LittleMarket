using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleMarket.Model
{
    public class Comentario
    {
        public int Id { get; set; }
        public string TextoComentario { get; set; }
        public string Id_Usuario { get; set; }
        public int Id_Producto { get; set; }
        public DateTime FechaDePublicacion { get; set; }
        public bool Activo { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
