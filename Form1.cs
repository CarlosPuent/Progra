using System;
using System.Windows.Forms;
using System;
using System.Windows.Forms;

namespace ProyectoParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(1800, 700); 
            this.MinimumSize = new Size(1000, 400); 

            
            this.comprasToolStripMenuItem.Click += new System.EventHandler(this.comprasToolStripMenuItem_Click);
            this.recepciónToolStripMenuItem.Click += new System.EventHandler(this.recepciónToolStripMenuItem_Click);
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            this.planillasToolStripMenuItem.Click += new System.EventHandler(this.planillasToolStripMenuItem_Click);

            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Mostrar el menú principal al cargar el formulario
            MostrarMenuPrincipal();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new CompraControl());
        }

        private void recepciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new RecepcionControl());
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new VentaControl());
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new ClientesGestion());
        }

        private void planillasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new PlanillaGestion());
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new EmpleadoGestion());
        }

        private void MostrarUserControl(UserControl control)
        {
            // Limpiar solo los controles del panel de contenido
            panelContenido.Controls.Clear();

            // Configurar el UserControl para llenar el panel
            control.Dock = DockStyle.Fill;

            // Suscribir al evento VolverClicked del UserControl si implementa la interfaz
            if (control is IVolverControl volverControl)
            {
                volverControl.VolverClicked += (s, args) => RegresarAlMenuPrincipal();
            }

            // Agregar el UserControl al panel de contenido
            panelContenido.Controls.Add(control);
        }

        private void RegresarAlMenuPrincipal()
        {
            panelContenido.Controls.Clear(); // Limpiar solo los controles del panel

            MostrarMenuPrincipal(); // Llamar al método para mostrar el menú principal
        }

        private void MostrarMenuPrincipal()
        {
            
            comprasToolStripMenuItem.Visible = true;
            recepciónToolStripMenuItem.Visible = true;
            ventasToolStripMenuItem.Visible = true;
            clientesToolStripMenuItem.Visible = true;
            planillasToolStripMenuItem.Visible = true;
            empleadosToolStripMenuItem.Visible = true;

            
            panelContenido.Dock = DockStyle.Fill;
        }

        private void planillasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

    private void panelContenido_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }

    
    public interface IVolverControl
    {
        event EventHandler VolverClicked;
    }
}


