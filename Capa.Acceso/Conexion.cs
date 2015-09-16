using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Capa.Acceso
{
    public class Conexion
    {

     public static string LeerCC
        {
            get { return "Server=localhost; Port=3306; User Id=root; password=erika12345;  Persist Security Info=True; database=Clinica"; }
        }
    }
}
