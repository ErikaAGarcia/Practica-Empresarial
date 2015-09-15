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
    public partial class NuevoExpediente : Form
    {

        public NuevoExpediente()
        {
            InitializeComponent();
        }

        private void NuevoExpediente_Load(object sender, EventArgs e)
        {
            string[] items = { "SanJosé", "Alajuela", "Cartago", "Heredia", "Guanacaste", "Puntarenas", "Limón" };
            ComboProvincia.Items.AddRange(items);

            //Inhabilitadas al principio y esperando accion para ser habilitadas.
            this.txtNomEnfermedad.Enabled = false;
            this.comboEmbarazo.Enabled = false;
            this.comboLactancia.Enabled = false;
            this.txtTranstornosMenstruales.Enabled = false;

        }
        //Llena el combobox de cantones segun la provincia seleccionada.
        private void ComboProvincia_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int index = ComboProvincia.SelectedIndex;
            if (index == 0)
            {
                comboCanton.Items.Clear();
                string[] items0 = { "SanJosé", "Escazú", "Desamparados", "Puriscal", "Tarrazú", "Aserrí" ,
                                   "Mora","Goicoechea","SantaAna","Alajuelita","VásquezdeCoronado","Acosta",
                                   "Tibás","Moravia","MontesdeOca","Turrubares","Dota","Curridabat",
                                   "PérezZeledón","LeónCortésCastro" };
                comboCanton.Items.AddRange(items0);
            }

            if (index == 1)
            {
                comboCanton.Items.Clear();
                string[] items1 = { "Alajuela", "SanRamón", "Grecia", "SanMateo", "Atenas", "Naranjo", "Palmares" ,
                                   "Poás","Orotina","SanCarlos","Zarcero","ValverdeVega","Upala","LosChiles","Guatuso"};
                comboCanton.Items.AddRange(items1);
            }

            if (index == 2)
            {
                comboCanton.Items.Clear();
                string[] items2 = { "Cartago", "Paraíso", "LaUnión", "Jiménez", "Turrialba", "Alvarado", "Oreamuno", "ElGuarco" };
                comboCanton.Items.AddRange(items2);
            }
            if (index == 3)
            {
                comboCanton.Items.Clear();
                string[] items3 = { "Heredia", "Barva", "SantoDomingo", "SantaBárbara", "SanRafael", "SanIsidro" ,
                                   "Belén","Flores","SanPablo","Sarapiquí"};
                comboCanton.Items.AddRange(items3);
            }
            if (index == 4)
            {
                comboCanton.Items.Clear();
                string[] items4 = { "Liberia", "Nicoya", "SantaCruz", "Bagaces", "Carrillo", "Cañas" ,
                                   "Abangares","Tilarán","Nandayure","LaCruz","Hojancha"};
                comboCanton.Items.AddRange(items4);
            }
            if (index == 5)
            {
                comboCanton.Items.Clear();
                string[] items5 = { "Puntarenas", "Esparza", "BuenosAires", "MontesdeOro", "Osa", "Quepos" ,
                                   "Golfito","CotoBrus","Parrita","Corredores","Garabito"};
                comboCanton.Items.AddRange(items5);
            }
            if (index == 6)
            {
                comboCanton.Items.Clear();
                string[] items6 = { "Limón", "Pococí", "Siquirres", "Talamanca", "Matina", "Guácimo" };
                comboCanton.Items.AddRange(items6);
            }
        }

        //Activa el txt de enfermedades si padece de alguna.
        private void comboEnfermedad_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string opcion = comboEnfermedad.SelectedItem.ToString();

            if (opcion.Equals("Si"))
            {

                this.txtNomEnfermedad.Enabled = true;

            }
            else
            {
                this.txtNomEnfermedad.Enabled = false;

            }
        }




        //Activa la parte de damas si genero es femenino.
        private void comboGenero_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string opcion = comboGenero.SelectedItem.ToString();

            if (opcion.Equals("Femenino"))
            {
                this.comboEmbarazo.Enabled = true;
                this.comboLactancia.Enabled = true;
                this.txtTranstornosMenstruales.Enabled = true;

            }
            else
            {
                this.comboEmbarazo.Enabled = false;
                this.comboLactancia.Enabled = false;
                this.txtTranstornosMenstruales.Enabled = false;
            }

        }


        private void btnIngresarPaciente_Click(object sender, EventArgs e)
        {
            int index1 = ComboProvincia.SelectedIndex;
            Capa.Models.Pacientes.Paciente item = new Models.Pacientes.Paciente();
            Capa.Busines.Pacientes agregar = new Busines.Pacientes();

            item.Nombre_Paciente = txtNomPaciente.Text;
            item.Cedula_Paciente = txtCedulaPaciente.Text;
            item.Telefono_Oficina = int.Parse(txtTelefOficina.Text);
            item.Telefono_Habitacion = int.Parse(txtTelefonoHabitacion.Text);
            item.Ocupacion_Paciente = txtOcupacionPaciente.Text;


            if (index1 == 0)
            {
                item.Provincia_Paciente = Models.Pacientes.Provincia.SanJosé;
                int canton = comboCanton.SelectedIndex;
                if (canton == 0) item.Canton_Paciente = Models.Pacientes.Canton.SanJosé;
                if (canton == 1) item.Canton_Paciente = Models.Pacientes.Canton.Escazú;
                if (canton == 2) item.Canton_Paciente = Models.Pacientes.Canton.Desamparados;
                if (canton == 3) item.Canton_Paciente = Models.Pacientes.Canton.Puriscal;
                if (canton == 4) item.Canton_Paciente = Models.Pacientes.Canton.Tarrazú;
                if (canton == 5) item.Canton_Paciente = Models.Pacientes.Canton.Aserrí;
                if (canton == 6) item.Canton_Paciente = Models.Pacientes.Canton.Mora;
                if (canton == 7) item.Canton_Paciente = Models.Pacientes.Canton.Goicoechea;
                if (canton == 8) item.Canton_Paciente = Models.Pacientes.Canton.SantaAna;
                if (canton == 9) item.Canton_Paciente = Models.Pacientes.Canton.Alajuelita;
                if (canton == 10) item.Canton_Paciente = Models.Pacientes.Canton.VásquezdeCoronado;
                if (canton == 11) item.Canton_Paciente = Models.Pacientes.Canton.Acosta;
                if (canton == 12) item.Canton_Paciente = Models.Pacientes.Canton.Tibás;
                if (canton == 13) item.Canton_Paciente = Models.Pacientes.Canton.Moravia;
                if (canton == 14) item.Canton_Paciente = Models.Pacientes.Canton.MontesdeOca;
                if (canton == 15) item.Canton_Paciente = Models.Pacientes.Canton.Turrubares;
                if (canton == 16) item.Canton_Paciente = Models.Pacientes.Canton.Dota;
                if (canton == 17) item.Canton_Paciente = Models.Pacientes.Canton.Curridabat;
                if (canton == 18) item.Canton_Paciente = Models.Pacientes.Canton.PérezZeledón;
                if (canton == 19) item.Canton_Paciente = Models.Pacientes.Canton.LeónCortésCastro;
            }

            if (index1 == 1)
            {
                item.Provincia_Paciente = Models.Pacientes.Provincia.Alajuela;
                int canton = comboCanton.SelectedIndex;
                if (canton == 0) item.Canton_Paciente = Models.Pacientes.Canton.Alajuela;
                if (canton == 1) item.Canton_Paciente = Models.Pacientes.Canton.SanRamón;
                if (canton == 2) item.Canton_Paciente = Models.Pacientes.Canton.Grecia;
                if (canton == 3) item.Canton_Paciente = Models.Pacientes.Canton.SanMateo;
                if (canton == 4) item.Canton_Paciente = Models.Pacientes.Canton.Atenas;
                if (canton == 5) item.Canton_Paciente = Models.Pacientes.Canton.Naranjo;
                if (canton == 6) item.Canton_Paciente = Models.Pacientes.Canton.Palmares;
                if (canton == 7) item.Canton_Paciente = Models.Pacientes.Canton.Poás;
                if (canton == 8) item.Canton_Paciente = Models.Pacientes.Canton.Orotina;
                if (canton == 9) item.Canton_Paciente = Models.Pacientes.Canton.SanCarlos;
                if (canton == 10) item.Canton_Paciente = Models.Pacientes.Canton.Zarcero;
                if (canton == 11) item.Canton_Paciente = Models.Pacientes.Canton.ValverdeVega;
                if (canton == 12) item.Canton_Paciente = Models.Pacientes.Canton.Upala;
                if (canton == 13) item.Canton_Paciente = Models.Pacientes.Canton.LosChiles;
                if (canton == 14) item.Canton_Paciente = Models.Pacientes.Canton.Guatuso;
            }

            if (index1 == 2)
            {

                item.Provincia_Paciente = Models.Pacientes.Provincia.Cartago;
                int canton = comboCanton.SelectedIndex;
                if (canton == 0) item.Canton_Paciente = Models.Pacientes.Canton.Cartago;
                if (canton == 1) item.Canton_Paciente = Models.Pacientes.Canton.Paraíso;
                if (canton == 2) item.Canton_Paciente = Models.Pacientes.Canton.LaUnión;
                if (canton == 3) item.Canton_Paciente = Models.Pacientes.Canton.Jiménez;
                if (canton == 4) item.Canton_Paciente = Models.Pacientes.Canton.Turrialba;
                if (canton == 5) item.Canton_Paciente = Models.Pacientes.Canton.Alvarado;
                if (canton == 6) item.Canton_Paciente = Models.Pacientes.Canton.Oreamuno;
                if (canton == 7) item.Canton_Paciente = Models.Pacientes.Canton.ElGuarco;

            }
            if (index1 == 3)
            {
                item.Provincia_Paciente = Models.Pacientes.Provincia.Heredia;
                int canton = comboCanton.SelectedIndex;
                if (canton == 0) item.Canton_Paciente = Models.Pacientes.Canton.Heredia;
                if (canton == 1) item.Canton_Paciente = Models.Pacientes.Canton.Barva;
                if (canton == 2) item.Canton_Paciente = Models.Pacientes.Canton.SantoDomingo;
                if (canton == 3) item.Canton_Paciente = Models.Pacientes.Canton.SantaBárbara;
                if (canton == 4) item.Canton_Paciente = Models.Pacientes.Canton.SanRafael;
                if (canton == 5) item.Canton_Paciente = Models.Pacientes.Canton.SanIsidro;
                if (canton == 6) item.Canton_Paciente = Models.Pacientes.Canton.Belén;
                if (canton == 7) item.Canton_Paciente = Models.Pacientes.Canton.Flores;
                if (canton == 8) item.Canton_Paciente = Models.Pacientes.Canton.SanPablo;
                if (canton == 9) item.Canton_Paciente = Models.Pacientes.Canton.Sarapiquí;

            }
            if (index1 == 4)
            {
                item.Provincia_Paciente = Models.Pacientes.Provincia.Guanacaste;
                int canton = comboCanton.SelectedIndex;
                if (canton == 0) item.Canton_Paciente = Models.Pacientes.Canton.Liberia;
                if (canton == 1) item.Canton_Paciente = Models.Pacientes.Canton.Nicoya;
                if (canton == 2) item.Canton_Paciente = Models.Pacientes.Canton.SantaCruz;
                if (canton == 3) item.Canton_Paciente = Models.Pacientes.Canton.Bagaces;
                if (canton == 4) item.Canton_Paciente = Models.Pacientes.Canton.Carrillo;
                if (canton == 5) item.Canton_Paciente = Models.Pacientes.Canton.Cañas;
                if (canton == 6) item.Canton_Paciente = Models.Pacientes.Canton.Abangares;
                if (canton == 7) item.Canton_Paciente = Models.Pacientes.Canton.Tilarán;
                if (canton == 8) item.Canton_Paciente = Models.Pacientes.Canton.Nandayure;
                if (canton == 9) item.Canton_Paciente = Models.Pacientes.Canton.LaCruz;
                if (canton == 10) item.Canton_Paciente = Models.Pacientes.Canton.Hojancha;
            }
            if (index1 == 5)
            {
                item.Provincia_Paciente = Models.Pacientes.Provincia.Puntarenas;
                int canton = comboCanton.SelectedIndex;
                if (canton == 0) item.Canton_Paciente = Models.Pacientes.Canton.Puntarenas;
                if (canton == 1) item.Canton_Paciente = Models.Pacientes.Canton.Esparza;
                if (canton == 2) item.Canton_Paciente = Models.Pacientes.Canton.BuenosAires;
                if (canton == 3) item.Canton_Paciente = Models.Pacientes.Canton.MontesdeOro;
                if (canton == 4) item.Canton_Paciente = Models.Pacientes.Canton.Osa;
                if (canton == 5) item.Canton_Paciente = Models.Pacientes.Canton.Quepos;
                if (canton == 6) item.Canton_Paciente = Models.Pacientes.Canton.Golfito;
                if (canton == 7) item.Canton_Paciente = Models.Pacientes.Canton.CotoBrus;
                if (canton == 8) item.Canton_Paciente = Models.Pacientes.Canton.Parrita;
                if (canton == 9) item.Canton_Paciente = Models.Pacientes.Canton.Corredores;

            }
            if (index1 == 6)
            {
                item.Provincia_Paciente = Models.Pacientes.Provincia.Limón;
                int canton = comboCanton.SelectedIndex;
                if (canton == 0) item.Canton_Paciente = Models.Pacientes.Canton.Limón;
                if (canton == 1) item.Canton_Paciente = Models.Pacientes.Canton.Pococí;
                if (canton == 2) item.Canton_Paciente = Models.Pacientes.Canton.Siquirres;
                if (canton == 3) item.Canton_Paciente = Models.Pacientes.Canton.Talamanca;
                if (canton == 4) item.Canton_Paciente = Models.Pacientes.Canton.Matina;
                if (canton == 5) item.Canton_Paciente = Models.Pacientes.Canton.Guácimo;
            }

            int Trat = comboTratamiento.SelectedIndex;
            if (Trat == 0) item.Recibe_Tratamiento = Models.Pacientes.SI_NO.Si;
            else item.Recibe_Tratamiento = Models.Pacientes.SI_NO.No;

            item.Direccion = txtDireccionPaciente.Text;
            item.Correo = txtCorreo.Text; //validar formato
            item.Recomendado = txtRecomendadoPor.Text;
            item.Extension = txtExtension.Text;
            item.Apartado = txtApartado.Text;
            item.Caso_Emergencia = txtNombreParentesco.Text;

            int gen = comboGenero.SelectedIndex;
            if (gen == 0) item.Genero = Models.Pacientes.Genero.Masculino;
            else item.Genero = Models.Pacientes.Genero.Femenino;


            item.Enfermedades = txtNomEnfermedad.Text;

            int parent = comboParentesco.SelectedIndex;
            if (parent == 0) item.Parentezco = Models.Pacientes.Parentezco.Padre;
            if (parent == 1) item.Parentezco = Models.Pacientes.Parentezco.Madre;
            if (parent == 2) item.Parentezco = Models.Pacientes.Parentezco.Suegro;
            if (parent == 3) item.Parentezco = Models.Pacientes.Parentezco.Suegra;
            if (parent == 4) item.Parentezco = Models.Pacientes.Parentezco.Hijo;
            if (parent == 5) item.Parentezco = Models.Pacientes.Parentezco.Hija;
            if (parent == 6) item.Parentezco = Models.Pacientes.Parentezco.Yerno;
            if (parent == 7) item.Parentezco = Models.Pacientes.Parentezco.Nuera;
            if (parent == 8) item.Parentezco = Models.Pacientes.Parentezco.Abuelo;
            if (parent == 9) item.Parentezco = Models.Pacientes.Parentezco.Abuela;
            if (parent == 10) item.Parentezco = Models.Pacientes.Parentezco.Hermano;
            if (parent == 11) item.Parentezco = Models.Pacientes.Parentezco.Hermana;
            if (parent == 12) item.Parentezco = Models.Pacientes.Parentezco.Cuñada;
            if (parent == 13) item.Parentezco = Models.Pacientes.Parentezco.Cuñado;
            if (parent == 14) item.Parentezco = Models.Pacientes.Parentezco.Nieto;
            if (parent == 15) item.Parentezco = Models.Pacientes.Parentezco.Nieta;
            if (parent == 16) item.Parentezco = Models.Pacientes.Parentezco.Tía;
            if (parent == 17) item.Parentezco = Models.Pacientes.Parentezco.Tío;
            if (parent == 18) item.Parentezco = Models.Pacientes.Parentezco.Sobrino;
            if (parent == 19) item.Parentezco = Models.Pacientes.Parentezco.Sobrina;
            if (parent == 20) item.Parentezco = Models.Pacientes.Parentezco.Primo;
            if (parent == 21) item.Parentezco = Models.Pacientes.Parentezco.Prima;
            if (parent == 22) item.Parentezco = Models.Pacientes.Parentezco.Biznieto;
            if (parent == 23) item.Parentezco = Models.Pacientes.Parentezco.Biznieta;
            if (parent == 24) item.Parentezco = Models.Pacientes.Parentezco.Amigo;
            if (parent == 25) item.Parentezco = Models.Pacientes.Parentezco.Amiga;



            item.TelefonoParentezco = txtTelefParentesco.Text;
            item.Medico = txtMedico.Text;
            item.Fecha = Convert.ToDateTime(dateTimeFecha.Text);
            item.NumeroExpediente = int.Parse(txtNumeroExpediente.Text);

            int oper = comboOperaciones.SelectedIndex;
            if (oper == 0) item.OperacionesMedica = Models.Pacientes.SI_NO.Si;
            else item.OperacionesMedica = Models.Pacientes.SI_NO.No;

            int alteracion = comboAlteracionSalud.SelectedIndex;
            if (alteracion == 0) item.AlteracionSalud = Models.Pacientes.SI_NO.Si;
            else item.AlteracionSalud = Models.Pacientes.SI_NO.No;


            int reaccion = comboAlergias.SelectedIndex;
            if (reaccion == 0) item.Reacciones = Models.Pacientes.Alergias.Aspirina;
            if (reaccion == 1) item.Reacciones = Models.Pacientes.Alergias.Penicilina;
            if (reaccion == 2) item.Reacciones = Models.Pacientes.Alergias.Sulfas;
            if (reaccion == 3) item.Reacciones = Models.Pacientes.Alergias.OtrosMedicamentos;

            int emb = comboEmbarazo.SelectedIndex;
            if (emb == 0) item.Embarazo = Models.Pacientes.SI_NO.Si;
            else item.Embarazo = Models.Pacientes.SI_NO.No;

            int lact = comboLactancia.SelectedIndex;
            if (lact == 0) item.Lactancia = Models.Pacientes.SI_NO.Si;
            else item.Lactancia = Models.Pacientes.SI_NO.No;


            item.TrastornosMenstruales = txtTranstornosMenstruales.Text;
            item.Observaciones = txtObservaciones.Text;


            agregar.AgregarPaciente(item);

            //try
            //{
            //    conexion = "Server=localhost; Uid=root; DataBase=clinica; Password=hola;";
            //    conectar.ConnectionString = conexion;
            //    conectar.Open();
            //    MessageBox.Show("Conectado");

            //    conectar.ConnectionString  =
            //  "insert into clinica (Nombre_Paciente,Cedula_Paciente,Telefono_Of + "', '" + txtDireccionPaciente + "', '" + txtCorreo + "','" + txtRecomendadoPor + "','" + txtExtension + "','" + txtApartado + "','" + txtNombreParentesco + "',  '" + comboGenero.SelectedText.ToString() + "',  '" + txtNomEnfermedad + "',  '" + comboParentesco.SelectedText.ToString() + "','" + txtTelefParentesco + "','" + txtMedico + "','" + dateTimeFecha + "','" + txtNumeroExpediente + "','" + comboOperaciones.SelectedText.ToString() + "','" + comboAlteracionSalud.SelectedText.ToString() + "','" + comboAlergias.SelectedText.ToString() + "','" + comboEmbarazo.SelectedText.ToString() + "','" + comboLactancia.SelectedText.ToString() + "','" + txtTranstornosMenstruales + "','" + txtObservaciones + "',)";
            //    MessageBox.Show("Registro Exitoso");
            //    conectar.Close();
            //}
            //catch (MySqlException error)
            //{
            //  MessageBox.Show("Inserción fallida" + Convert.ToString(error));icina,Telefono_Habitacion,Ocupacion_Paciente,Provincia_Paciente,Canton_Paciente,Recibe_Tratamiento,Direccion,Correo,Recomendado,Extension,Apartado,Caso_Emergencia,Genero,Enfermedades,Parentezco,TelefonoParentezco,Medico,Fecha,NumeroExpediente,OperacionesMedica,AlteracionSalud,Reacciones,Embarazo,Lactancia,TrastornosMenstruales,Observaciones) values ('+ Nombre +','" + txtNomPaciente.Text + "','" + txtCedulaPaciente.Text + "','" + txtTelefOficina + "','" + txtTelefonoHabitacion + "','" + txtOcupacionPaciente + "','" + ComboProvincia + "','" + ComboProvincia.SelectedText.ToString() + "','" + comboCanton.SelectedText.ToString() + "','" + comboTratamiento.SelectedText.ToString()
            //    //throw;
            //}




        }

        private void btnRegresarMenu_Click(object sender, EventArgs e)
        {
            Form PrincipalMenu = new MenuPrincipal();
            PrincipalMenu.Show();
        }

        private void btnEliminarPaciente_Click_1(object sender, EventArgs e)
        {
            Form EliminarPaciente = new Eliminar_Paciente();
            EliminarPaciente.Show();
        }


        private void btnBuscarPaciente_Click_1(object sender, EventArgs e)
        {

            Form BuscarPaciente = new BuscarPaciente();
            BuscarPaciente.Show();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
