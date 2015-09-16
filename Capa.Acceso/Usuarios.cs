﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace Capa.Acceso
{
    public class Usuarios
    {

        public static bool Grabar(Capa.Models.NuevoUsuario pEntidad)
        {
            using (var cn = new MySqlConnection(Conexion.LeerCC))
            {
                // Contamos cuantos amigos existen segun el codamigo o nombre
                using (var cmd = new MySqlCommand(@"select ifnull(count(Nombre_Completo),0) from Clinica where Nombre_Completo=@Nombre ", cn))
                {
                    //Asignar valores a los parametros
                    cmd.Parameters.AddWithValue("Nombre", pEntidad.Nombre_Completo);
                    cmd.Parameters.AddWithValue("Usuario", pEntidad.Nombre_Usuario);
                    cmd.Parameters.AddWithValue("TipoUsuario", pEntidad.Tipo_Usuario);
                    cmd.Parameters.AddWithValue("email", pEntidad.Correo);
                    cmd.Parameters.AddWithValue("Pass", pEntidad.Contraseña);
                    cmd.Parameters.AddWithValue("Fecha", pEntidad.Fecha_Creacion);
                 

                    cn.Open();
                    // Ejecutamos el comando y verificamos si el resultado es mayor a cero actualizar, caso contrario insertar
                    if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                    {
                        //// Si es mayor a cero, quiere decir que existe al menos un registro con los datos ingresados
                        //// Entonces antes de actualizar, hacer las siguientes comprobaciones
                        //if (pEntidad.Nombre_Completo == "")
                        //    throw new Exception("El amigo(a) ya esta registrado en el sistema, verifique los datos por favor!...");

                        // Verifica si ya existe un registro con el mismo nombre del distrito
                        cmd.CommandText = @"select ifnull(count(Nombre_Completo),0) from Usuarios where Nombre_Completo<>@nombre ";
                        if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                            throw new Exception("No se puede grabar un valor duplicado, verifique los datos por favor!...");

                        // Si las comprobaciones anteriores resultaron ser falsa, entonces actualizar
                        cmd.CommandText = @"insert into Usuarios (Nombre_Completo,Nombre_Usuario,Tipo_Usuario,Correo,Contraseña,Fecha_Creacion) values (@Nombre, @Usuario, @TipoUsuario, @email, @Pass, @Fecha);";
                    }
                    
                    // Ejecutamos el comando que puede ser para update o insert
                    return Convert.ToBoolean(cmd.ExecuteNonQuery());
                }
            }
        }

        //public static bool Eliminar(Entidades.Amigo pEntidad)
        //{
        //    using (var cn = new MySqlConnection(conexion.LeerCC))
        //    {
        //        // Como nadie depende de esta entidad (amigos) no habra comprobaciones de dependencia
        //        using (var cmd = new MySqlCommand(@"delete from amigos where codamigo=@cod;", cn))
        //        {
        //            cmd.Parameters.AddWithValue("cod", pEntidad.codamigo);

        //            cn.Open();
        //            // Ejecuta el comando
        //            return Convert.ToBoolean(cmd.ExecuteNonQuery());
        //        }
        //    }
        //}

        //public static List<Entidades.Amigo> Leer(string dato)
        //{
        //    // Crea un obj. lista de tipo Amigo
        //    var lista = new List<Entidades.Amigo>();
        //    // Crear el objeto de conexion
        //    using (var cn = new MySqlConnection(conexion.LeerCC))
        //    {
        //        // crear el comando
        //        using (var cmd = new MySqlCommand("select codamigo, nomdistrito, nombre, dni, fecnac, sexo, direccion, telefono from distritos inner join amigos on distritos.coddistrito = amigos.coddistrito where nombre like Concat(@nom, '%');", cn))
        //        {
        //            //Asignar valores a los parametros
        //            cmd.Parameters.AddWithValue("nom", dato);

        //            // Abrir el objeto de conexion
        //            cn.Open();
        //            using (var dr = cmd.ExecuteReader())
        //            {
        //                while (dr.Read())
        //                {
        //                    // Crea un objeto del distrito
        //                    var oDistrito = new Entidades.Distrito();
        //                    var oAmigo = new Entidades.Amigo();
        //                    oAmigo.codamigo = Convert.ToInt32(dr[dr.GetOrdinal("codamigo")]);

        //                    // Aqui obtenemos el nombre del distrito para luego ser enviado al objeto amigo
        //                    oDistrito.nomdistrito = Convert.ToString(dr[dr.GetOrdinal("nomdistrito")]);
        //                    oAmigo.edistrito = oDistrito;

        //                    oAmigo.nombre = Convert.ToString(dr[dr.GetOrdinal("nombre")]);
        //                    oAmigo.dni = Convert.ToString(dr[dr.GetOrdinal("dni")]);
        //                    oAmigo.fecnac = Convert.ToDateTime(dr[dr.GetOrdinal("fecnac")]);
        //                    oAmigo.sexo = Convert.ToString(dr[dr.GetOrdinal("sexo")]);
        //                    oAmigo.direccion = Convert.ToString(dr[dr.GetOrdinal("direccion")]);
        //                    oAmigo.telefono = Convert.ToString(dr[dr.GetOrdinal("telefono")]);
        //                    // El objeto amigo es agregado a la lista
        //                    lista.Add(oAmigo);
        //                    // marcamos a los objetos creamos como nulos
        //                    oDistrito = null;
        //                    oAmigo = null;
        //                }
        //            }

        //            // Retorna una lista de datos
        //            return lista;
        //        }
            }
        
    
}
