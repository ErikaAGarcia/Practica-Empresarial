using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Models
{
    public class NuevoInventario
    {
        public int Id_Inventario { get; set; }
        public string Nombre_Producto { get; set; }
        public int Cantidad_Productos { get; set; }
         public DateTime Fecha_Ingreso { get; set; }
        public DateTime Fecha_Vencimiento { get; set; }
        public string Codigo_producto { get; set; }

    }
}
