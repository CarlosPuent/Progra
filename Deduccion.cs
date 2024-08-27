using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParcial
{
    public class Deduccion
    {
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }

        public Deduccion(string descripcion, decimal monto)
        {
            Descripcion = descripcion;
            Monto = monto;
        }
    }
}
