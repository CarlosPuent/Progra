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
            this.Size = new Size(1800, 700); // Establecer tama�o inicial del formulario
            this.MinimumSize = new Size(1000, 400); // Establecer un tama�o m�nimo para evitar que los controles se corten
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Mostrar el men� principal al cargar el formulario
            MostrarMenuPrincipal();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new CompraControl());
        }

        private void recepci�nToolStripMenuItem_Click(object sender, EventArgs e)
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

            MostrarMenuPrincipal(); // Llamar al m�todo para mostrar el men� principal
        }

        private void MostrarMenuPrincipal()
        {
            // Si el men� principal son simplemente botones en el form, aseg�rate de que est�n visibles
            comprasToolStripMenuItem.Visible = true;
            recepci�nToolStripMenuItem.Visible = true;
            ventasToolStripMenuItem.Visible = true;
            clientesToolStripMenuItem.Visible = true;
            // Aqu� puedes agregar cualquier control o contenido adicional que quieras mostrar en el men� principal
            // Como ejemplo, si tienes un label o alg�n otro control que deba estar visible, lo configuras aqu�.

            // Establecer el control Dock en el panel para que ocupe todo el espacio disponible
            panelContenido.Dock = DockStyle.Fill;
        }

        private void panelContenido_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    // Interfaz para los controles que necesitan la opci�n de "Volver"
    public interface IVolverControl
    {
        event EventHandler VolverClicked;
    }
}

