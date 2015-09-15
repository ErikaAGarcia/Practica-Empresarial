using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Capa.Formularios
{
    public partial class BuscarPaciente : Form
    {
        //public string conexion;
        //public string consulta;
        //public MySqlConnection con = new MySqlConnection();

        public BuscarPaciente()
        {
            InitializeComponent();
        }

        private void BuscarPaciente_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    conexion = "Server=localhost; User id=root; DataBase=clinica; Password=hola;";
            //    con.ConnectionString = conexion;
            //    con.Open();
            //    MessageBox.Show("Conectado");

            //    consulta = "select Nombre_Paciente,Cedula_Paciente,Provincia_Paciente";
            //    MySqlCommand comandos = new MySqlCommand();
            //    comandos.Connection = con;
            //    comandos.CommandText = consulta;
            //    MySqlDataReader leer = comandos.ExecuteReader();
            //}
            //catch (MySqlException error)
            //{
            //    MessageBox.Show("Error" + Convert.ToString(error));
            //    //throw;
            //}


        }

        private void btnEditarPaciente_Click(object sender, EventArgs e)
        {
            Form EditarPaciente = new EditarPacientes();
            EditarPaciente.Show();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }






    }
}
