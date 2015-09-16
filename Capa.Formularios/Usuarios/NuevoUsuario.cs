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

        private void button1_Click(object sender, EventArgs e)
        {
            var oEntidad = new Capa.Models.NuevoUsuario();
            if (usuario != null)
                
            oEntidad.Nombre_Completo = textNombreCompleto.Text.Trim();
            oEntidad.Nombre_Usuario = textUsuario.Text.Trim();
            oEntidad.Tipo_Usuario= Models.TipoUsuario.AdministradorGeneral;
            oEntidad.Fecha_Creacion = DateTime.Now;
            oEntidad.Correo = textCorreo.Text.Trim();
            oEntidad.Contraseña = textContraseña.Text.Trim();
          

            try
            {
                Capa.Busines.UsuariosMetodos.Grabar(oEntidad);
              
                Leer("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally { oEntidad = null; }
        }
    }
}
