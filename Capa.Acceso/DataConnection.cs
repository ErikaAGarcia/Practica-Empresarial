using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Capa.Accesos
{
    public class DataConection
    {


        public static MySqlConnection obtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=localhost;database=clinica;Uid=root; pwd=;");
            conectar.Open();
            return conectar;
        }


    }
}
