using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParcial
{
    public class Medicamento
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int CantidadDisponible { get; set; }
        public string Categoria { get; set; }
        public string Marca { get; set; }
        public string Pasillo { get; set; }
        public string Estante { get; set; }
        public string UbicacionDetallada { get; set; }
        public DateTime FechaExpiracion { get; set; }

        public Medicamento(int id, string codigo, string nombre, int cantidadDisponible, string categoria, string marca, string pasillo, string estante, string ubicacionDetallada, DateTime fechaExpiracion)
        {
            Id = id;
            Codigo = codigo;
            Nombre = nombre;
            CantidadDisponible = cantidadDisponible;
            Categoria = categoria;
            Marca = marca;
            Pasillo = pasillo;
            Estante = estante;
            UbicacionDetallada = ubicacionDetallada;
            FechaExpiracion = fechaExpiracion;
        }
    }
}
