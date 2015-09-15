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
    public partial class CuentasPorCobrar : Form
    {
        public CuentasPorCobrar()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnVerCuentas_Click(object sender, EventArgs e)
        {
            Form BuscarCuentasCobrar = new BuscarCuentasCobrar();
            BuscarCuentasCobrar.Show();
        }
    }
}
