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
    public partial class LoginForm : Form
    {
        // Simulación de una base de datos de empleados (usuarios)
        private List<Empleado> empleados = new List<Empleado>
        {
            new Empleado("admin", "admin123", "Admin"),
            new Empleado("vendedor", "vendedor123", "Vendedor"),
            new Empleado("cajero", "cajero123", "Cajero"),
            new Empleado("farma", "farma123", "Farmacéutico")

            //us = admin contr = admin123
        };

        public LoginForm()
        {
            InitializeComponent();
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            
            txtContraseña.UseSystemPasswordChar = true;

            
            chkMostrarContraseña.CheckedChanged += (s, e) =>
            {
                txtContraseña.UseSystemPasswordChar = !chkMostrarContraseña.Checked;
            };
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Por favor, ingrese tanto el nombre de usuario como la contraseña.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            var empleado = empleados.FirstOrDefault(u => u.NombreUsuario == nombreUsuario && u.Contraseña == contraseña);

            if (empleado != null)
            {
                MessageBox.Show($"¡Bienvenido, {empleado.Nombre}!", "Inicio de Sesión Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AbrirFormularioSegunRol(empleado.Rol);
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AbrirFormularioSegunRol(string rol)
        {
            Form formToOpen = null;

            // Abrir formulario según el rol del usuario
            switch (rol)
            {
                case "Admin":
                    formToOpen = new Form1(); 
                    break;
                case "Vendedor":
                    //formToOpen = new FormVendedor(); // Form para punto de venta
                    break;
                case "Cajero":
                    formToOpen = new FormCajero(); 
                    break;
                case "Farmacéutico":
                    formToOpen = new FormFarmaceutico();
                    break;
                default:
                    MessageBox.Show("Rol no reconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            if (formToOpen != null)
            {
               
                formToOpen.FormClosed += (s, args) => Application.Exit();

                formToOpen.Show();
                this.Hide(); // Ocultar el formulario de inicio de sesión después de iniciar sesión
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Confirmar si el usuario desea salir
            var result = MessageBox.Show("¿Está seguro de que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}

