﻿using System;
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
    public partial class CuentasPorPagar : Form
    {
        public CuentasPorPagar()
        {
            InitializeComponent();
        }

        private void btnVercuentasPagar_Click(object sender, EventArgs e)
        {
            Form BuscarCuentasPagar = new BuscarCuentaPagar();
            BuscarCuentasPagar.Show();
        }
    }
}
