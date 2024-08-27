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
    public partial class FormPlanillas : Form
    {
       
        public decimal SalarioBase { get; private set; }
        public int HorasExtras { get; private set; }
        public decimal DeduccionesExtras { get; private set; }

        public FormPlanillas(Empleado empleado)
        {
            InitializeComponent();

            
            lblEmpleado.Text = $"Empleado: {empleado.Nombre} - {empleado.Rol}";
        }

        private void FormPlanillas_Load(object sender, EventArgs e)
        {
           
            txtSalarioBase.Clear();
            txtHorasExtras.Clear();
            txtDeduccionesExtras.Clear();
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            // Validar Salario Base
            if (!decimal.TryParse(txtSalarioBase.Text, out decimal salarioBase) || salarioBase <= 0 || salarioBase > 10000)
            {
                MessageBox.Show("Ingrese un salario base válido entre 1 y 10,000.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar Horas Extras
            if (!int.TryParse(txtHorasExtras.Text, out int horasExtras) || horasExtras < 0 || horasExtras > 100)
            {
                MessageBox.Show("Ingrese un número válido de horas extras (0 a 100).", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar Deducciones Extras
            if (!decimal.TryParse(txtDeduccionesExtras.Text, out decimal deduccionesExtras) || deduccionesExtras < 0 || deduccionesExtras > 500)
            {
                MessageBox.Show("Ingrese un monto válido de deducciones extras (0 a 500).", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Asignar los valores validados a las propiedades
            SalarioBase = salarioBase;
            HorasExtras = horasExtras;
            DeduccionesExtras = deduccionesExtras;

            // Cerrar el formulario y devolver el resultado de diálogo OK
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            // Cerrar el formulario y devolver el resultado de diálogo Cancel
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblEmpleado_Click(object sender, EventArgs e)
        {

        }
    }
}



