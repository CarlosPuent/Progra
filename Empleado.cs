using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParcial
{
    public class Empleado
    {
       
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Rol { get; set; } 

        
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }

       
        public Empleado(int id, string codigo, string nombre, string apellido, string rol)
        {
            Id = id;
            Codigo = codigo;
            Nombre = nombre;
            Apellido = apellido;
            Rol = rol;
        }

        
        public Empleado(int id, string codigo, string nombre, string apellido, string rol, string correo, string telefono, string direccion)
        {
            Id = id;
            Codigo = codigo;
            Nombre = nombre;
            Apellido = apellido;
            Rol = rol;
            Correo = correo;
            Telefono = telefono;
            Direccion = direccion;
        }

        
        public Empleado(string nombreUsuario, string contraseña, string rol)
        {
            NombreUsuario = nombreUsuario;
            Contraseña = contraseña;
            Rol = rol;
        }
    }
}

