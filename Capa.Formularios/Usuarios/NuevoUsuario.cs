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
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private Capa.Models.NuevoUsuario usuario;
        private void NuevoUsuario_Load(object sender, EventArgs e)
        {

        }

        private void Leer(string dato)
        {
            try
            {
                dgv.DataSource = Busines.UsuariosMetodos.Listar(dato);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv.AutoGenerateColumns = false;
            Leer("");
        }
    }
}
