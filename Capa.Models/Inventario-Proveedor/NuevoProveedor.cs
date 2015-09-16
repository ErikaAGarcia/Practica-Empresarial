using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Models
{
    public class NuevoProveedor
    {
        public int Id_Proveedor { get; set; }
        public string Cedula_Juridica { get; set; }
        public string Direccion_Proveedor { get; set; }
        public string Telefono_Proveedor { get; set; }
        public DateTime Dia_Entrega { get; set; }
        public string Nombre_Producto { get; set; }
        public string Numero_Cuenta { get; set; }

    }
}
