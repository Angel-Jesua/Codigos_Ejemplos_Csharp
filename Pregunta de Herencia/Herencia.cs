using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Herencia
    {
        static void Main(string[] args)
        {
            medico med = new medico();

            string nombre;
            string apellidos;
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido");
            apellidos = Console.ReadLine();
            Console.WriteLine("Ingrese el año en el que entro");
            int anoingreso = Convert.ToInt32(Console.ReadLine());
            int antiguedadanos = med.CalcularAntiguedad(new DateTime(anoingreso, 1, 1));
            Console.WriteLine("Su antiguedad es: "+antiguedadanos+ "años");
        }
    }
}
