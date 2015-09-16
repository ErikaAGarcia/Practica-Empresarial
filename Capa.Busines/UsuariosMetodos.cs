using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Busines
{
    public class UsuariosMetodos
    {
        public static bool Grabar(Capa.Models.NuevoUsuario pEntidad)
        {
            // Una regla del negocio, es que, el nombre del amigo(a) no podra ser un valor nulo o vacio
            // Sera obligatorio ingresar dicho dato
            if (string.IsNullOrEmpty(pEntidad.Nombre_Completo.Trim()))
                throw new Exception("El nombre del usuario no puede ser vacio");

            // Otra regla del negocio es que el numero de dni debe ser de ocho caracteres
            if (pEntidad.Contraseña.Trim().Length < 8 | pEntidad.Contraseña.Trim().Length > 8)
                throw new Exception("El numero de dni debera ser de 8 caracteres");

            return Capa.Acceso.Usuarios.Grabar(pEntidad);
           
        }

        //public static bool Eliminar(Entidades.Amigo pEntidad)
        //{
        //    return AccesoDato.adAmigo.Eliminar(pEntidad);
        //}

        public static List<Capa.Models.NuevoUsuario> Listar(string dato)
        {
            return Capa.Acceso.Usuarios.Leer(dato);
        }
    }
}

   
