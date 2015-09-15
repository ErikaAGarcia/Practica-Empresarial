using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa.Formularios
{
    public partial class NuevoExpediente : Form
    {
        public NuevoExpediente()
        {
            InitializeComponent();
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            Form BuscarPaciente = new BuscarPaciente();
            BuscarPaciente.Show();
        }

        private void btnEliminarPaciente_Click(object sender, EventArgs e)
        {
            Form Eliminar_Paciente = new Eliminar_Paciente();
            Eliminar_Paciente.Show();
        }
    }
}
