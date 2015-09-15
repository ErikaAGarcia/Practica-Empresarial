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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NuevoUsuario = new NuevoUsuario();
            NuevoUsuario.Show();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NuevoProveedor = new NuevoProveedor();
            NuevoProveedor.Show();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            //Form NuevaAgenda = new NuevaAgenda();
            //NuevaAgenda.Show();

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Productos = new Productos();
            Productos.Show();
        }

        private void nuevoPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NuevoExpediente = new NuevoExpediente();
            NuevoExpediente.Show();
        }

        private void cuentasPorPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form CuentasPorPagar = new CuentasPorPagar();
            CuentasPorPagar.Show();
        }

        private void cuentasPorCobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form CuentasPorCobrar = new CuentasPorCobrar();
            CuentasPorCobrar.Show();
        }

        private void buscarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Historiales = new Historiales();
            Historiales.Show();
        }

        private void crearFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NuevaFactura = new NuevaFactura();
            NuevaFactura.Show();
        }

        private void nuevaCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NuevaAgenda = new NuevaAgenda();
            NuevaAgenda.Show();
        }
    }
}
