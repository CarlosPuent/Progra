using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParcial
{
    public class Bonificacion
    {
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }

        public Bonificacion(string descripcion, decimal monto)
        {
            Descripcion = descripcion;
            Monto = monto;
        }
    }
}
