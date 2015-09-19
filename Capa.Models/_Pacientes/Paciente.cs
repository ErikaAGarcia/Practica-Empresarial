using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Models._Pacientes
{
    public class Paciente
    {
        public string idPaciente { get; set; }
        public string Nombre_Paciente { get; set; }
        public string Cedula_Paciente { get; set; }
        public int Telefono_Oficina { get; set; }
        public int Telefono_Habitacion { get; set; }
        public string Ocupacion_Paciente { get; set; }
        public Provincia Provincia_Paciente { get; set; }
        public Canton Canton_Paciente { get; set; }
        public SI_NO Recibe_Tratamiento { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Recomendado { get; set; }
        public string Extension { get; set; }
        public string Apartado { get; set; }
        public string Caso_Emergencia { get; set; }
        public Genero Genero { get; set; }
        public string Enfermedades { get; set; }
        public Parentezco Parentezco { get; set; }
        public string TelefonoParentezco { get; set; }
        public string Medico { get; set; }
        public DateTime Fecha { get; set; }
        public int NumeroExpediente { get; set; }
        public SI_NO OperacionesMedica { get; set; }
        public SI_NO AlteracionSalud { get; set; }
        public Alergias Reacciones { get; set; }

        //DAMAS:
        public SI_NO Embarazo { get; set; }
        public SI_NO Lactancia { get; set; }
        public string TrastornosMenstruales { get; set; }
        public string Observaciones { get; set; }
    }
}
