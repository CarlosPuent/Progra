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
    public partial class EmpleadoGestion : UserControl
    {
        private List<Empleado> empleados = new List<Empleado>();
        private int nextId = 1; // Controla el próximo ID a asignar

        public EmpleadoGestion()
        {
            InitializeComponent();
            ConfigurarColumnasEmpleados();
            CargarCargos(); // Cargar cargos al iniciar
            CargarEmpleados(); // Cargar empleados al iniciar
        }

        private void ConfigurarColumnasEmpleados()
        {
            dgvEmpleados.Columns.Clear();

            // Configurar el ajuste de las columnas
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvEmpleados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvEmpleados.ScrollBars = ScrollBars.Both;

            // Configuración de columnas con anchos específicos
            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colId",
                HeaderText = "ID",
                Width = 50, // Ancho para ID
                ReadOnly = true
            });

            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCodigo",
                HeaderText = "Código",
                Width = 80 // Ancho para Código
            });

            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNombre",
                HeaderText = "Nombre",
                Width = 150 
            });

            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colApellido",
                HeaderText = "Apellido",
                Width = 150 
            });

            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCargo",
                HeaderText = "Cargo",
                Width = 100 
            });

            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCorreo",
                HeaderText = "Correo",
                Width = 160 
            });

            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colTelefono",
                HeaderText = "Teléfono",
                Width = 130 
            });

            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDireccion",
                HeaderText = "Dirección",
                Width = 550 
            });
        }

        private void CargarCargos()
        {
            // Lista de cargos predefinidos
            string[] cargos = { "Cajero", "Farmacéutico", "Gerente", "Asistente", "Seguridad", "Contador" };

            // Limpiar el ComboBox antes de cargar nuevos datos
            cmbCargo.Items.Clear();

            // Agregar los cargos al ComboBox
            cmbCargo.Items.AddRange(cargos);

           
            if (cmbCargo.Items.Count > 0)
            {
                cmbCargo.SelectedIndex = 0;
            }
        }

        private void CargarEmpleados()
        {
            dgvEmpleados.Rows.Clear();

            foreach (var empleado in empleados)
            {
                // Agregar una nueva fila al DataGridView
                int rowIndex = dgvEmpleados.Rows.Add();
                DataGridViewRow row = dgvEmpleados.Rows[rowIndex];

                // Asignar valores a cada columna por nombre
                row.Cells["colId"].Value = empleado.Id;
                row.Cells["colCodigo"].Value = empleado.Codigo;
                row.Cells["colNombre"].Value = empleado.Nombre;
                row.Cells["colApellido"].Value = empleado.Apellido;
                row.Cells["colCargo"].Value = empleado.Rol;
                row.Cells["colCorreo"].Value = empleado.Correo;
                row.Cells["colTelefono"].Value = empleado.Telefono;
                row.Cells["colDireccion"].Value = empleado.Direccion; 
            }
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            Empleado nuevoEmpleado = new Empleado(
                nextId++,
                txtCodigo.Text,
                txtNombres.Text,
                txtApellidos.Text,
                cmbCargo.SelectedItem.ToString(),
                txtCorreo.Text,
                txtTelefono.Text,
                txtDireccion.Text // Asignación directa de la dirección
            );

            empleados.Add(nuevoEmpleado);
            CargarEmpleados();
            LimpiarCampos();
        }

        private bool ValidarCampos()
        {
            // Validar campos vacíos
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtNombres.Text) ||
                string.IsNullOrWhiteSpace(txtApellidos.Text) ||
                string.IsNullOrWhiteSpace(cmbCargo.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar formato de correo
            if (!IsValidEmail(txtCorreo.Text))
            {
                MessageBox.Show("Ingrese un correo válido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar formato de teléfono (solo números y longitud específica)
            if (!long.TryParse(txtTelefono.Text, out _) || txtTelefono.Text.Length < 8 || txtTelefono.Text.Length > 15)
            {
                MessageBox.Show("Ingrese un número de teléfono válido (solo números, entre 8 y 15 dígitos).", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar código único solo si se está agregando un nuevo empleado
            if (dgvEmpleados.SelectedRows.Count == 0 && empleados.Any(c => c.Codigo == txtCodigo.Text))
            {
                MessageBox.Show("El código del empleado ya existe.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnModificarEmpleado_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un empleado para modificar.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidarCampos())
            {
                return;
            }

            int selectedIndex = dgvEmpleados.SelectedRows[0].Index;
            Empleado empleadoExistente = empleados[selectedIndex];

            
            if (empleados.Any(c => c.Codigo == txtCodigo.Text && c.Id != empleadoExistente.Id))
            {
                MessageBox.Show("El código de empleado ya existe en otro registro.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            empleadoExistente.Codigo = txtCodigo.Text;
            empleadoExistente.Nombre = txtNombres.Text;
            empleadoExistente.Apellido = txtApellidos.Text;
            empleadoExistente.Rol = cmbCargo.SelectedItem.ToString();
            empleadoExistente.Correo = txtCorreo.Text;
            empleadoExistente.Telefono = txtTelefono.Text;
            empleadoExistente.Direccion = txtDireccion.Text; 

            CargarEmpleados();
            LimpiarCampos();
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un empleado para eliminar.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar este empleado?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                int selectedIndex = dgvEmpleados.SelectedRows[0].Index;
                empleados.RemoveAt(selectedIndex);
                CargarEmpleados();
                LimpiarCampos();
            }
        }

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            cmbCargo.SelectedIndex = -1;
            txtCorreo.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.ToLower();
            var empleadosFiltrados = empleados.Where(emp =>
                emp.Codigo.ToLower().Contains(filtro) ||
                emp.Nombre.ToLower().Contains(filtro) ||
                emp.Apellido.ToLower().Contains(filtro) ||
                emp.Rol.ToLower().Contains(filtro) ||
                emp.Correo.ToLower().Contains(filtro) ||
                emp.Telefono.Contains(filtro) ||
                emp.Direccion.ToLower().Contains(filtro)).ToList();

            dgvEmpleados.Rows.Clear();

            foreach (var empleado in empleadosFiltrados)
            {
                dgvEmpleados.Rows.Add(empleado.Id, empleado.Codigo, empleado.Nombre, empleado.Apellido, empleado.Rol, empleado.Correo, empleado.Telefono, empleado.Direccion);
            }
        }

        private void dgvEmpleados_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvEmpleados.SelectedRows[0];
                txtCodigo.Text = selectedRow.Cells["colCodigo"].Value.ToString();
                txtNombres.Text = selectedRow.Cells["colNombre"].Value.ToString();
                txtApellidos.Text = selectedRow.Cells["colApellido"].Value.ToString();
                cmbCargo.Text = selectedRow.Cells["colCargo"].Value.ToString();
                txtCorreo.Text = selectedRow.Cells["colCorreo"].Value.ToString();
                txtTelefono.Text = selectedRow.Cells["colTelefono"].Value.ToString();
                txtDireccion.Text = selectedRow.Cells["colDireccion"].Value.ToString(); 
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

