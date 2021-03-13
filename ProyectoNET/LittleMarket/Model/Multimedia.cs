using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleMarket.Model
{
    public class Multimedia
    {
        public int Id { get; set; }
        public int Id_Producto { get; set; }
        public bool Tipo { get; set; }
        public int Id_Imagen { get; set; }
        public int Id_Video { get; set; }
        public virtual ICollection<Imagen> Imagen { get; set; }//en duda aqui creo que es Icollection enluar de solo public virtual pero podria estar mal

        public virtual ICollection<Video> Video { get; set; } //en duda en duda aqui creo que es Icollection enluar de solo public virtual pero podria estar mal

        public virtual Producto Producto { get; set; }

    }
}
