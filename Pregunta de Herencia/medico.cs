using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class medico : Empleado
    {
        private int salarioPorHora;
        private int hora;
        private DateTime ant;
        public medico() { }

        public medico(string nombre, string apellidos, DateTime ant, int salarioPorHora, int hora)
          : base(nombre, apellidos, ant) /*En C# no existe la denominada super como en Java para llamar a los constructores,
                                          * en este caso utiliza : base para hacerlo */
        {
            this.salarioPorHora = salarioPorHora;
            this.hora = hora;
            this.ant = ant;
        }
        public int CalculoSalario(int salarioPorHora, int hora)
        {
            return salarioPorHora * hora;

        }
        public int CalcularAntiguedad(DateTime ant)
        {
            int antiguedad = DateTime.Now.Year - ant.Year;
            return antiguedad;
        }
    }
}

