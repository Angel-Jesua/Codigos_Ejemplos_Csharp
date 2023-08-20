using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Empleado
    {
        private String nombre;
        private String apellidos;
        private DateTime ant;

        public Empleado() { }

        public Empleado(string nombre, string apellidos, DateTime ant)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.ant = ant;
        }


    }
}
