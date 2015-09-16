using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Models
{
   public class NuevoUsuario
    {

        public string Nombre_Completo { get; set; }
        public int Id_Usuario { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Correo { get; set; }
        public TipoUsuario Tipo_Usuario { get; set; }
        public DateTime Fecha_Creacion { get; set; }
    }
}
