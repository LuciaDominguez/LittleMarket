using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleMarket.Model
{
    public class Estado
    {
        public int Id { get; set; }
        public int Id_Pais { get; set; }
        public string Nombre { get; set; }
        public virtual Pais Pais { get; set; }
        public virtual ICollection<Ciudad> Ciudad { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
