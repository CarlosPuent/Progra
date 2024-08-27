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
    public partial class InventarioControl : UserControl
    {
        private List<Medicamento> medicamentos;

        public InventarioControl()
        {
            InitializeComponent();
            ConfigurarColumnasInventario();
            CargarDatosDefaultComboBox();
            CargarInventario();
            dgvInventario.SelectionChanged += dgvInventario_SelectionChanged;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
        }

        private void ConfigurarColumnasInventario()
        {
            dgvInventario.Columns.Clear();

            // Configuración de las columnas del DataGridView
            dgvInventario.Columns.Add("colId", "ID");
            dgvInventario.Columns["colId"].Visible = false;

            dgvInventario.Columns.Add("colCodigo", "Código");
            dgvInventario.Columns["colCodigo"].Width = 80;

            dgvInventario.Columns.Add("colNombre", "Nombre del Medicamento");
            dgvInventario.Columns["colNombre"].Width = 150;

            dgvInventario.Columns.Add("colCantidad", "Cantidad Disponible");
            dgvInventario.Columns["colCantidad"].Width = 120;

            dgvInventario.Columns.Add("colCategoria", "Categoría");
            dgvInventario.Columns["colCategoria"].Width = 120;

            dgvInventario.Columns.Add("colMarca", "Marca");
            dgvInventario.Columns["colMarca"].Width = 120;

            dgvInventario.Columns.Add("colPasillo", "Pasillo");
            dgvInventario.Columns["colPasillo"].Width = 80;

            dgvInventario.Columns.Add("colEstante", "Estante");
            dgvInventario.Columns["colEstante"].Width = 80;

            dgvInventario.Columns.Add("colUbicacion", "Ubicación Detallada");
            dgvInventario.Columns["colUbicacion"].Width = 200;

            dgvInventario.Columns.Add("colFechaExpiracion", "Fecha de Expiración");
            dgvInventario.Columns["colFechaExpiracion"].Width = 150;

            dgvInventario.Columns.Add("colEstadoStock", "Estado de Stock");
            dgvInventario.Columns["colEstadoStock"].Width = 120;
        }

        private void CargarInventario()
        {

            if (medicamentos == null || medicamentos.Count == 0)
            {
                medicamentos = ObtenerDatosInventario();
            }

            dgvInventario.Rows.Clear();
            lblAlertaStock.Text = string.Empty;

            foreach (var medicamento in medicamentos)
            {
                int rowIndex = dgvInventario.Rows.Add();
                DataGridViewRow row = dgvInventario.Rows[rowIndex];

                row.Cells["colId"].Value = medicamento.Id;
                row.Cells["colCodigo"].Value = medicamento.Codigo;
                row.Cells["colNombre"].Value = medicamento.Nombre;
                row.Cells["colCantidad"].Value = medicamento.CantidadDisponible;
                row.Cells["colCategoria"].Value = medicamento.Categoria;
                row.Cells["colMarca"].Value = medicamento.Marca;
                row.Cells["colPasillo"].Value = medicamento.Pasillo;
                row.Cells["colEstante"].Value = medicamento.Estante;
                row.Cells["colUbicacion"].Value = medicamento.UbicacionDetallada;
                row.Cells["colFechaExpiracion"].Value = medicamento.FechaExpiracion.ToShortDateString();
                row.Cells["colEstadoStock"].Value = medicamento.CantidadDisponible < 10 ? "Bajo Stock" : "Suficiente";

                if (medicamento.CantidadDisponible < 10)
                {
                    lblAlertaStock.Text += $"¡Alerta! El medicamento {medicamento.Nombre} tiene bajo stock.\n";
                }
            }
        }

        private void CargarDatosDefaultComboBox()
        {
            cmbCategoria.Items.Clear();
            cmbCategoria.Items.AddRange(new string[] { "Analgésico", "Antiinflamatorio", "Antibiótico", "Antihistamínico" });

            cmbMarca.Items.Clear();
            cmbMarca.Items.AddRange(new string[] { "Genérico", "Bayer", "Pfizer", "Novartis" });

            cmbPasillo.Items.Clear();
            cmbPasillo.Items.AddRange(new string[] { "Pasillo 1", "Pasillo 2", "Pasillo 3", "Pasillo 4" });

            cmbEstante.Items.Clear();
            cmbEstante.Items.AddRange(new string[] { "Estante A", "Estante B", "Estante C", "Estante D" });
        }

        private List<Medicamento> ObtenerDatosInventario()
        {
            // Cargar datos predeterminados en la lista de medicamentos
            return new List<Medicamento>
            {
                new Medicamento(1, "COD001", "Paracetamol", 8, "Analgésico", "Genérico", "Pasillo 1", "Estante A", "A1", DateTime.Now.AddMonths(12)),
                new Medicamento(2, "COD002", "Ibuprofeno", 15, "Antiinflamatorio", "Bayer", "Pasillo 2", "Estante B", "B2", DateTime.Now.AddMonths(8))
            };
        }

        private void dgvInventario_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInventario.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvInventario.SelectedRows[0];
                txtId.Text = selectedRow.Cells["colId"].Value.ToString();
                txtCodigo.Text = selectedRow.Cells["colCodigo"].Value.ToString();
                txtNombre.Text = selectedRow.Cells["colNombre"].Value.ToString();
                txtCantidad.Text = selectedRow.Cells["colCantidad"].Value.ToString();
                cmbCategoria.Text = selectedRow.Cells["colCategoria"].Value.ToString();
                cmbMarca.Text = selectedRow.Cells["colMarca"].Value.ToString();
                cmbPasillo.Text = selectedRow.Cells["colPasillo"].Value.ToString();
                cmbEstante.Text = selectedRow.Cells["colEstante"].Value.ToString();
                txtUbicacion.Text = selectedRow.Cells["colUbicacion"].Value.ToString();

                if (DateTime.TryParse(selectedRow.Cells["colFechaExpiracion"].Value.ToString(), out DateTime fechaExpiracion))
                {
                    fecha.Value = fechaExpiracion;
                }
                else
                {
                    MessageBox.Show("Error al convertir la fecha de expiración.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarMedicamento(txtBuscar.Text);
        }

        private void BuscarMedicamento(string criterio)
        {
            if (string.IsNullOrWhiteSpace(criterio))
            {
                CargarInventario();
            }
            else
            {
                var medicamentosFiltrados = medicamentos.Where(m =>
                    m.Nombre.Contains(criterio, StringComparison.OrdinalIgnoreCase) ||
                    m.Codigo.Contains(criterio, StringComparison.OrdinalIgnoreCase)).ToList();

                dgvInventario.Rows.Clear();
                lblAlertaStock.Text = string.Empty;

                foreach (var medicamento in medicamentosFiltrados)
                {
                    int rowIndex = dgvInventario.Rows.Add();
                    DataGridViewRow row = dgvInventario.Rows[rowIndex];

                    row.Cells["colId"].Value = medicamento.Id;
                    row.Cells["colCodigo"].Value = medicamento.Codigo;
                    row.Cells["colNombre"].Value = medicamento.Nombre;
                    row.Cells["colCantidad"].Value = medicamento.CantidadDisponible;
                    row.Cells["colCategoria"].Value = medicamento.Categoria;
                    row.Cells["colMarca"].Value = medicamento.Marca;
                    row.Cells["colPasillo"].Value = medicamento.Pasillo;
                    row.Cells["colEstante"].Value = medicamento.Estante;
                    row.Cells["colUbicacion"].Value = medicamento.UbicacionDetallada;
                    row.Cells["colFechaExpiracion"].Value = medicamento.FechaExpiracion.ToShortDateString();
                    row.Cells["colEstadoStock"].Value = medicamento.CantidadDisponible < 10 ? "Bajo Stock" : "Suficiente";

                    if (medicamento.CantidadDisponible < 10)
                    {
                        lblAlertaStock.Text += $"¡Alerta! El medicamento {medicamento.Nombre} tiene bajo stock.\n";
                    }
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvInventario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un medicamento para modificar.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidarCampos())
            {
                return;
            }

            int selectedIndex = dgvInventario.SelectedRows[0].Index;
            Medicamento medicamentoExistente = medicamentos.FirstOrDefault(m => m.Id == Convert.ToInt32(txtId.Text));

            if (medicamentoExistente != null)
            {
                medicamentoExistente.Codigo = txtCodigo.Text;
                medicamentoExistente.Nombre = txtNombre.Text;
                medicamentoExistente.CantidadDisponible = int.Parse(txtCantidad.Text);
                medicamentoExistente.Categoria = cmbCategoria.Text;
                medicamentoExistente.Marca = cmbMarca.Text;
                medicamentoExistente.Pasillo = cmbPasillo.Text;
                medicamentoExistente.Estante = cmbEstante.Text;
                medicamentoExistente.UbicacionDetallada = txtUbicacion.Text;
                medicamentoExistente.FechaExpiracion = fecha.Value;

                CargarInventario();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Medicamento no encontrado para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvInventario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un medicamento para eliminar.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar este medicamento?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                int selectedIndex = dgvInventario.SelectedRows[0].Index;
                int medicamentoId = Convert.ToInt32(dgvInventario.SelectedRows[0].Cells["colId"].Value);

                Medicamento medicamentoAEliminar = medicamentos.FirstOrDefault(m => m.Id == medicamentoId);

                if (medicamentoAEliminar != null)
                {
                    medicamentos.Remove(medicamentoAEliminar);
                    CargarInventario();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Medicamento no encontrado para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtCodigo.Clear();
            txtNombre.Clear();
            txtCantidad.Clear();
            cmbCategoria.SelectedIndex = -1;
            cmbMarca.SelectedIndex = -1;
            cmbPasillo.SelectedIndex = -1;
            cmbEstante.SelectedIndex = -1;
            txtUbicacion.Clear();
            fecha.Value = DateTime.Now;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCantidad.Text) ||
                cmbCategoria.SelectedIndex == -1 ||
                cmbMarca.SelectedIndex == -1 ||
                cmbPasillo.SelectedIndex == -1 ||
                cmbEstante.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtUbicacion.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(txtCantidad.Text, out _))
            {
                MessageBox.Show("Ingrese una cantidad válida.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnBuscar_Click(object sender, EventArgs e) { }

        private void lblAlertaStock_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

