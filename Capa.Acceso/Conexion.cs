using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Capa.Acceso
{
    public class Conexion
    {

        public static string Cadena
        {
            get
            {
                try
                {
                    return "server=localhost;User Id=root ; database= clinica;pwd=erika12345";
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    return ex.Message;
                }


            }
        }
    }
}
