using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleMarket.Model
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Correo { get; set; }
        public string Contra { get; set; }
        public int Id_Pais { get; set; }
        public int Id_Ciudad { get; set; }
        public int Id_Estado { get; set; }
        public bool Activo { get; set; }
        public DateTime UltimaConexion { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public int Id_MetodoDePago { get; set; }
        public virtual Pais Pais { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual Ciudad Ciudad { get; set; }
        public virtual ICollection<Direccion> Direccion { get; set; }
        public virtual ICollection<Pedido> Pedido { get; set; }
        public virtual ICollection<Comentario> Comentario { get; set; }
        public virtual ICollection<LikeProducto> LikeProducto { get; set; }

      
    }
}
