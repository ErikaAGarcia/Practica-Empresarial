using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace Capa.Acceso
{
    public class Usuarios
    {


        public static Capa.Models.NuevoUsuario NuevoUsuario(MySqlDataReader entidad)
        {
            var e = new Capa.Models.NuevoUsuario();

            e.Id_Usuario = Convert.ToInt32(entidad["Id_Usuario"]);
            e.Nombre_Completo = Convert.ToString(entidad["Nombre_Completo"]);
            e.Nombre_Usuario = Convert.ToString(entidad["Nombre_Usuario"]);
            e.Fecha_Creacion = Convert.ToDateTime(entidad["Fecha_Creacion"]);
            e.Correo = Convert.ToString(entidad["Correo"]);
            e.Contraseña = Convert.ToString(entidad["Contraseña"]);
            e.Tipo_Usuario = Models.TipoUsuario.AdministradorGeneral;
            return e;
        }
        //listar
        public static List<Models.NuevoUsuario> ListaUsuarios()
        {
            var lista = new List<Models.NuevoUsuario>();
            using (MySqlConnection cn = new MySqlConnection(Conexion.Cadena))
            {
                var consulta = "select * from Usuarios";
                var cmd = new MySqlCommand(consulta, cn);
                cn.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(NuevoUsuario(dr));
                }
                return lista;
            }
        }
        //agregar
        public static bool Agrega(Models.NuevoUsuario User)
        {

            using (MySqlConnection cn = new MySqlConnection(Conexion.Cadena))
            {
                var consulta = "insert into usuario values (@Nombre_Completo,@Nombre_Usuario,@Fecha_Creacion,@Correo,@Contraseña)";
                var cmd = new MySqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@Nombre_Completo", User.Nombre_Completo);////falta algo creo
                cmd.Parameters.AddWithValue("@Nombre_Usuario", User.Nombre_Usuario);////falta algo creo
                cmd.Parameters.AddWithValue("@Tipo_Usuario", User.Tipo_Usuario);
                cmd.Parameters.AddWithValue("@Fecha_Creacion", User.Fecha_Creacion);////falta algo creo
                cmd.Parameters.AddWithValue("@Correo", User.Correo);////falta algo creo
                cmd.Parameters.AddWithValue("@Contraseña", User.Contraseña);////falta algo creo
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
        }

        //actualizar
        public static bool actualizar(Models.NuevoUsuario User)
        {
            using (MySqlConnection cn = new MySqlConnection(Conexion.Cadena))
            {
                var consulta = "update usuario set Nombre_Completo=@Nombre_Completo,Nombre_Usuario=@Nombre_Usuario,@Tipo_Usuario=Tipo_Usuario,Fecha_Creacion=@Fecha_Creacion,Correo=@Correo,Contraseña=@Contraseña";
                var cmd = new MySqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@Nombre_Completo", User.Nombre_Completo);////falta algo creo
                cmd.Parameters.AddWithValue("@Nombre_Usuario", User.Nombre_Usuario);////falta algo creo
                cmd.Parameters.AddWithValue("@Tipo_Usuario", User.Tipo_Usuario);
                cmd.Parameters.AddWithValue("@Fecha_Creacion", User.Fecha_Creacion);////falta algo creo
                cmd.Parameters.AddWithValue("@Correo", User.Correo);////falta algo creo
                cmd.Parameters.AddWithValue("@Contraseña", User.Contraseña);////falta algo creo
                cmd.Parameters.AddWithValue("@Id_Usuario", User.Id_Usuario);////falta algo creo

                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteNonQuery());


            }
        }

        //Eliminar
        public static bool Eliminar(Models.NuevoUsuario User)
        {
            using (MySqlConnection cn = new MySqlConnection(Conexion.Cadena))

            {
                var consulta = "delete *from usuario where Id_Usuario=@Id_Usuario";
                var cmd = new MySqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@Id_Usuario", User.Id_Usuario);
                cn.Open();
                return Convert.ToBoolean(cmd.ExecuteNonQuery());

            }

        }
    }

    }
