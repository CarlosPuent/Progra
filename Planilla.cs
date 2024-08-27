using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParcial
{
    public class Planilla
    {
        public Empleado Empleado { get; set; }
        public decimal SalarioBase { get; set; }
        public int HorasExtras { get; set; }
        public decimal DeduccionesExtras { get; set; }
        public decimal DeduccionesTotales { get; set; }
        public decimal SueldoLiquido { get; set; }

        public Planilla(Empleado empleado, decimal salarioBase, int horasExtras, decimal deduccionesExtras)
        {
            Empleado = empleado;
            SalarioBase = salarioBase;
            HorasExtras = horasExtras;
            DeduccionesExtras = deduccionesExtras;
            CalcularDeducciones();
            CalcularSueldoLiquido();
        }

        // Método para calcular el salario por hora
        private decimal CalcularSalarioPorHora()
        {
            // Suponiendo 176 horas laborales al mes (22 días x 8 horas)
            return SalarioBase / 176;
        }

        // Método para calcular el valor total de las horas extras
        private decimal CalcularValorHorasExtras()
        {
            decimal salarioPorHora = CalcularSalarioPorHora();
            decimal tarifaHorasExtras = 1.5m; // 1.5 veces el salario base por hora
            return HorasExtras * salarioPorHora * tarifaHorasExtras;
        }

        public void CalcularDeducciones()
        {
            // Calcular deducciones estándar
            decimal renta = SalarioBase * 0.10m;
            decimal afp = SalarioBase * 0.07m;
            decimal isss = SalarioBase * 0.035m;

            // Calcular deducciones totales
            DeduccionesTotales = renta + afp + isss + DeduccionesExtras;
        }

        public void CalcularSueldoLiquido()
        {
            // Calcular sueldo líquido incluyendo las horas extras
            SueldoLiquido = (SalarioBase + CalcularValorHorasExtras()) - DeduccionesTotales;
        }
    }
}


