using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleMarket.Model
{
    public class Imagen
    {
        public int Id { get; set; }
        public int Foto { get; set; }/*Investigar el tipo de dato aceptable para Var binary*/

       // public virtual Multimedia Multimedia { get; set; }
        public virtual ICollection<Multimedia> Multimedia { get; set; }
    }
}
