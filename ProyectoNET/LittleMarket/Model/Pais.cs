using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleMarket.Model
{
    public class Pais
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<Estado> Estado { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }

    }
}
