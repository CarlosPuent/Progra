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
    public partial class FormFarmaceutico : Form
    {
        public FormFarmaceutico()
        {
            InitializeComponent();
            ConfigurarFormulario();
        }

        private void FormFarmaceutico_Load(object sender, EventArgs e)
        {

        }

        private void ConfigurarFormulario()
        {
            // Configurar el tamaño y las propiedades del formulario
            this.Size = new Size(1700, 700); // Establecer tamaño inicial
            this.MinimumSize = new Size(800, 400); // Establecer tamaño mínimo

            // Configurar el menú de opciones solo para la gestión de farmacia
            this.inventarioToolStripMenuItem.Click += new EventHandler(this.inventarioToolStripMenuItem_Click);
            this.recepcionToolStripMenuItem.Click += new EventHandler(this.recepcionToolStripMenuItem_Click);
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mostrar control de usuario para inventario de farmacia
            MostrarUserControl(new InventarioControl());
        }

        private void recepcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            MostrarUserControl(new RecepcionControl());
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

