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
    public partial class Logueo : Form
    {
        public Logueo()
        {
            InitializeComponent();
        }

        private void ButCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButIngresar_Click(object sender, EventArgs e)
        {
            Form MenuPrincipal = new MenuPrincipal();
            MenuPrincipal.Show();
            
        }
    }
}
