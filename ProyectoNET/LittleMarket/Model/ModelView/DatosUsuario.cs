using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleMarket.Model.ModelView
{
    public class DatosUsuario
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Correo { get; set; }
        public string Contra { get; set; }
        /*public bool? Activo { get; set; }
        public string? Telefono { get; set; }
        public DateTime? FechaDeNacimiento { get; set; }
        public int? Id_MetodoDePago { get; set; }*/
    }
}
