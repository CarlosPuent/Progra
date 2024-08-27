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
    public partial class PlanillaGestion : UserControl
    {
        private List<Empleado> empleados = new List<Empleado>();
        private List<Planilla> planillas = new List<Planilla>();
        private int nextEmpleadoId = 1; // Controla el próximo ID a asignar

        public PlanillaGestion()
        {
            InitializeComponent();
            this.Load += PlanillaGestion_Load;  
        }

        private void PlanillaGestion_Load(object sender, EventArgs e)
        {
            ConfigurarColumnasEmpleados();
            ConfigurarColumnasPlanillas();
            CargarEmpleados();
        }

        private void ConfigurarColumnasEmpleados()
        {
            dgvEmpleados.Columns.Clear();

            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colId",
                HeaderText = "ID",
                Width = 50,
                ReadOnly = true
            });

            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCodigo",
                HeaderText = "Código",
                Width = 80
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
                Name = "colRol",
                HeaderText = "Rol",
                Width = 100
            });
        }

        private void ConfigurarColumnasPlanillas()
        {
            dgvPlanillas.Columns.Clear();

            dgvPlanillas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colId",
                HeaderText = "ID",
                Width = 50,
                ReadOnly = true
            });

            dgvPlanillas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCodigo",
                HeaderText = "Código",
                Width = 80
            });

            dgvPlanillas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNombre",
                HeaderText = "Nombre",
                Width = 150
            });

            dgvPlanillas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colApellido",
                HeaderText = "Apellido",
                Width = 150
            });

            dgvPlanillas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colRol",
                HeaderText = "Rol",
                Width = 100
            });

            dgvPlanillas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colSalarioBase",
                HeaderText = "Salario Base",
                Width = 100
            });

            dgvPlanillas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colHorasExtras",
                HeaderText = "Horas Extras",
                Width = 80
            });

            dgvPlanillas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDeduccionesTotales",
                HeaderText = "Deducciones Totales",
                Width = 120
            });

            dgvPlanillas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colSueldoLiquido",
                HeaderText = "Sueldo Líquido",
                Width = 120
            });
        }

        private void CargarEmpleados()
        {
            empleados.Add(new Empleado(nextEmpleadoId++, "EMP001", "Carlos", "Gómez", "Cajero"));
            empleados.Add(new Empleado(nextEmpleadoId++, "EMP002", "María", "Pérez", "Farmacéutica"));
            empleados.Add(new Empleado(nextEmpleadoId++, "EMP003", "Luis", "Martínez", "Gerente"));
            empleados.Add(new Empleado(nextEmpleadoId++, "EMP004", "Ana", "Rodríguez", "Asistente"));

            dgvEmpleados.Rows.Clear();

            foreach (var empleado in empleados)
            {
                dgvEmpleados.Rows.Add(empleado.Id, empleado.Codigo, empleado.Nombre, empleado.Apellido, empleado.Rol);
            }
        }

        private void CargarPlanillas()
        {
            dgvPlanillas.Rows.Clear();

            foreach (var planilla in planillas)
            {
                dgvPlanillas.Rows.Add(
                    planilla.Empleado.Id,
                    planilla.Empleado.Codigo,
                    planilla.Empleado.Nombre,
                    planilla.Empleado.Apellido,
                    planilla.Empleado.Rol,
                    planilla.SalarioBase.ToString("F2"), 
                    planilla.HorasExtras,
                    planilla.DeduccionesTotales.ToString("F2"), 
                    planilla.SueldoLiquido.ToString("F2") // Formato con dos decimales
                );
            }
        }

        private void btnAgregarPlanilla_Click_1(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un empleado para agregar planilla.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedIndex = dgvEmpleados.SelectedRows[0].Index;
            Empleado empleadoSeleccionado = empleados[selectedIndex];

            if (planillas.Any(p => p.Empleado.Id == empleadoSeleccionado.Id))
            {
                MessageBox.Show("Ya existe una planilla para este empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (FormPlanillas formPlanilla = new FormPlanillas(empleadoSeleccionado))
            {
                if (formPlanilla.ShowDialog() == DialogResult.OK)
                {
                    
                    Planilla nuevaPlanilla = new Planilla(
                        empleadoSeleccionado,
                        formPlanilla.SalarioBase,
                        formPlanilla.HorasExtras,
                        formPlanilla.DeduccionesExtras
                    );

                    
                    planillas.Add(nuevaPlanilla);
                    CargarPlanillas();
                }
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvPlanillas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una planilla para quitar.");
                return;
            }

            // Confirmación antes de eliminar
            var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar esta planilla?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult != DialogResult.Yes)
            {
                return;
            }

            // Obtener la fila seleccionada del DataGridView de planillas
            DataGridViewRow selectedRow = dgvPlanillas.SelectedRows[0];

            // Obtener el ID del empleado de la fila seleccionada para quitar la planilla correspondiente
            int idEmpleado = Convert.ToInt32(selectedRow.Cells["colId"].Value);

            
            Planilla planillaAEliminar = planillas.FirstOrDefault(p => p.Empleado.Id == idEmpleado);
            if (planillaAEliminar != null)
            {
                planillas.Remove(planillaAEliminar);
                CargarPlanillas(); 
                MessageBox.Show("Planilla eliminada correctamente.");
            }
            else
            {
                MessageBox.Show("No se pudo encontrar la planilla a eliminar.");
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (dgvPlanillas.Rows.Count == 0)
            {
                MessageBox.Show("No hay planillas para confirmar.");
                return;
            }

            StringBuilder planillaDetalles = new StringBuilder();
            decimal totalDeducciones = 0;
            decimal totalSueldoLiquido = 0;

            planillaDetalles.AppendLine("Detalle de Planilla de Empleados");
            planillaDetalles.AppendLine("---------------------------------");

            // Recorrer todas las planillas para generar el archivo de detalles
            foreach (DataGridViewRow row in dgvPlanillas.Rows)
            {
                if (row.Cells["colCodigo"].Value == null ||
                    row.Cells["colNombre"].Value == null ||
                    row.Cells["colSalarioBase"].Value == null ||
                    row.Cells["colHorasExtras"].Value == null ||
                    row.Cells["colDeduccionesTotales"].Value == null ||
                    row.Cells["colSueldoLiquido"].Value == null)
                {
                    continue; // Si alguna celda es null, salta a la siguiente fila
                }

                string codigo = row.Cells["colCodigo"].Value.ToString();
                string nombre = row.Cells["colNombre"].Value.ToString();
                decimal salarioBase = Convert.ToDecimal(row.Cells["colSalarioBase"].Value);
                int horasExtras = Convert.ToInt32(row.Cells["colHorasExtras"].Value);
                decimal deduccionesTotales = Convert.ToDecimal(row.Cells["colDeduccionesTotales"].Value);
                decimal sueldoLiquido = Convert.ToDecimal(row.Cells["colSueldoLiquido"].Value);

                // Sumar deducciones y sueldos líquidos totales para la planilla
                totalDeducciones += deduccionesTotales;
                totalSueldoLiquido += sueldoLiquido;

                // Añadir detalles de la planilla al archivo
                planillaDetalles.AppendLine($"Código: {codigo}, Nombre: {nombre}, Salario Base: {salarioBase:C2}, Horas Extras: {horasExtras}, Deducciones: {deduccionesTotales:C2}, Sueldo Líquido: {sueldoLiquido:C2}");
            }

            planillaDetalles.AppendLine("---------------------------------");
            planillaDetalles.AppendLine($"Total Deducciones: {totalDeducciones:C2}");
            planillaDetalles.AppendLine($"Total Sueldo Líquido: {totalSueldoLiquido:C2}");

            // Mostrar el archivo en un MessageBox o guardarlo en un archivo físico si se requiere
            MessageBox.Show(planillaDetalles.ToString(), "Planilla Generada");

            // Limpiar planillas después de confirmar
            dgvPlanillas.Rows.Clear();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

    }
}
