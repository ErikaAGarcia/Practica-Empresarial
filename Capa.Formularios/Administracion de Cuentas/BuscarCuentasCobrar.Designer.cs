namespace Capa.Formularios
{
    partial class BuscarCuentasCobrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarCuentasCobrar));
            this.dataGridCuentasCobrar = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnActualizarCCobrar = new System.Windows.Forms.Button();
            this.btnEliminarCCobrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBuscarNombreCuenta = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCuentasCobrar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCuentasCobrar
            // 
            this.dataGridCuentasCobrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCuentasCobrar.Location = new System.Drawing.Point(94, 187);
            this.dataGridCuentasCobrar.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridCuentasCobrar.Name = "dataGridCuentasCobrar";
            this.dataGridCuentasCobrar.RowTemplate.Height = 24;
            this.dataGridCuentasCobrar.Size = new System.Drawing.Size(529, 197);
            this.dataGridCuentasCobrar.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnActualizarCCobrar);
            this.groupBox2.Controls.Add(this.btnEliminarCCobrar);
            this.groupBox2.Location = new System.Drawing.Point(94, 126);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(529, 57);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones en las Cuentas";
            // 
            // btnActualizarCCobrar
            // 
            this.btnActualizarCCobrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizarCCobrar.BackgroundImage")));
            this.btnActualizarCCobrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizarCCobrar.Location = new System.Drawing.Point(162, 17);
            this.btnActualizarCCobrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarCCobrar.Name = "btnActualizarCCobrar";
            this.btnActualizarCCobrar.Size = new System.Drawing.Size(83, 28);
            this.btnActualizarCCobrar.TabIndex = 1;
            this.btnActualizarCCobrar.UseVisualStyleBackColor = true;
            this.btnActualizarCCobrar.Click += new System.EventHandler(this.btnActualizarCCobrar_Click);
            // 
            // btnEliminarCCobrar
            // 
            this.btnEliminarCCobrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarCCobrar.BackgroundImage")));
            this.btnEliminarCCobrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarCCobrar.Location = new System.Drawing.Point(57, 17);
            this.btnEliminarCCobrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarCCobrar.Name = "btnEliminarCCobrar";
            this.btnEliminarCCobrar.Size = new System.Drawing.Size(89, 28);
            this.btnEliminarCCobrar.TabIndex = 0;
            this.btnEliminarCCobrar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnBuscarNombreCuenta);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(94, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(529, 82);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Cuenta Específica";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(430, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnBuscarNombreCuenta
            // 
            this.btnBuscarNombreCuenta.BackgroundImage = global::Capa.Formularios.Properties.Resources.boton_buscar;
            this.btnBuscarNombreCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarNombreCuenta.Location = new System.Drawing.Point(323, 25);
            this.btnBuscarNombreCuenta.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarNombreCuenta.Name = "btnBuscarNombreCuenta";
            this.btnBuscarNombreCuenta.Size = new System.Drawing.Size(91, 33);
            this.btnBuscarNombreCuenta.TabIndex = 3;
            this.btnBuscarNombreCuenta.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 32);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese el Nombre:";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Capa.Formularios.Properties.Resources.boton_cancelar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(325, 414);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 28);
            this.button1.TabIndex = 49;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BuscarCuentasCobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridCuentasCobrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BuscarCuentasCobrar";
            this.Text = "BuscarCuentas";
            this.Load += new System.EventHandler(this.BuscarCuentasCobrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCuentasCobrar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCuentasCobrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnActualizarCCobrar;
        private System.Windows.Forms.Button btnEliminarCCobrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarNombreCuenta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}