using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoParcial
{
    public partial class FormCajero : Form
    {
        public FormCajero()
        {
            InitializeComponent();
            ConfigurarFormulario();
        }

        private void FormCajero_Load(object sender, EventArgs e)
        {

        }

        private void ConfigurarFormulario()
        {
            
            this.Size = new Size(1200, 600); // Establecer tamaño inicial
            this.MinimumSize = new Size(800, 400); // Establecer tamaño mínimo

           
            this.ventasToolStripMenuItem.Click += new EventHandler(this.ventasToolStripMenuItem_Click);
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            MostrarUserControl(new VentaControl());
        }

        private void MostrarUserControl(UserControl control)
        {
            
            panelContenido.Controls.Clear();

           
            control.Dock = DockStyle.Fill;

            
            panelContenido.Controls.Add(control);
        }

        private void panelContenido_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

