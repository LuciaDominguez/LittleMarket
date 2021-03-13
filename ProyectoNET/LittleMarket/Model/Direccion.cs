using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleMarket.Model
{
    public class Direccion
    {
        public int Id { get; set; }
        public int Id_Usuario { get; set; }
        public int Id_Ciudad { get; set; }

        public string Calle { get; set; }
        public string Numero { get; set; }
        public string CodigoPostal { get; set; }
        public string Departamento { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Ciudad Ciudad { get; set; }
        public virtual ICollection<Pedido> Pedido { get; set; }

    }
}
