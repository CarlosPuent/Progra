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
    public partial class FormDescuento : Form
    {
       
        public int PuntosUsados { get; private set; }
        public decimal SaldoUsado { get; private set; }
        public decimal DescuentoAplicado { get; private set; }

        
        public bool UsarPuntos { get; private set; }
        public bool UsarGiftCard { get; private set; }

        private Cliente clienteActual;

        public FormDescuento(Cliente cliente)
        {
            InitializeComponent();
            clienteActual = cliente;

            
            lblPuntosDisponibles.Text = $"Puntos Disponibles: {cliente.Puntos}";
            lblGiftCardSaldo.Text = $"Saldo de Gift Card: {cliente.SaldoGiftCard:C2}";

            txtDescuentoAplicado.Enabled = false; 
        }

        private void FormDescuento_Load(object sender, EventArgs e)
        {
           
            txtPuntosUsar.Clear();
            txtGiftCardUsar.Clear();
            txtDescuentoAplicado.Text = "0.00";
        }

        private void btnAplicar_Click_1(object sender, EventArgs e)
        {
           
            UsarPuntos = chkUsarPuntos.Checked;
            UsarGiftCard = chkUsarGiftCard.Checked;

            
            if (UsarPuntos)
            {
                if (!int.TryParse(txtPuntosUsar.Text, out int puntos) || puntos < 0 || puntos > clienteActual.Puntos)
                {
                    MessageBox.Show("Ingrese un número válido de puntos a usar.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                PuntosUsados = puntos;
            }
            else
            {
                PuntosUsados = 0; // No se usan puntos si no está seleccionado
            }

            // Validar entrada de saldo de gift card si se desea usar la gift card
            if (UsarGiftCard)
            {
                if (!decimal.TryParse(txtGiftCardUsar.Text, out decimal saldo) || saldo < 0 || saldo > clienteActual.SaldoGiftCard)
                {
                    MessageBox.Show("Ingrese un saldo válido de gift card a usar.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SaldoUsado = saldo;
            }
            else
            {
                SaldoUsado = 0; // No se usa saldo si no está seleccionado
            }

            // Calcular el descuento total aplicado
            DescuentoAplicado = CalcularDescuentoTotal(PuntosUsados, SaldoUsado);
            txtDescuentoAplicado.Text = DescuentoAplicado.ToString("C2");

            // Confirmar la operación y cerrar el formulario
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            // Permite al usuario cerrar el formulario sin realizar cambios
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private decimal CalcularDescuentoTotal(int puntos, decimal saldo)
        {
            // Calcular el descuento basado en puntos y saldo de gift card
            decimal descuentoPorPuntos = (puntos / 10m); // Cada 10 puntos equivalen a $1 de descuento
            return descuentoPorPuntos + saldo;
        }
    }
}
