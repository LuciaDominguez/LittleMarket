using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleMarket.Model
{
    public class Ciudad
    {

        public int Id { get; set; }
        public int Id_Estado { get; set; }
        public string Nombre { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }

        public virtual ICollection<Direccion> Direccion { get; set; }
    }
}
