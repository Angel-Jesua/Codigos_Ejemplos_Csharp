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
            int anoingreso;
            int antiguedadanos;
            int salario;
            int horas;
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido");
            apellidos = Console.ReadLine();
            do
            {
                Console.WriteLine("Ingrese el año en el que entro");
                anoingreso = Convert.ToInt32(Console.ReadLine());
                antiguedadanos = med.CalcularAntiguedad(new DateTime(anoingreso, 1, 1));
            } while (anoingreso < 1970 || anoingreso > 2023);
            do {
                Console.WriteLine("Ingrese en dolares cuanto gana la hora");
                salario = Convert.ToInt32(Console.ReadLine());
            } while (salario<0||salario>35);
            do
            {
                Console.WriteLine("Ingrese cuantas horas trabaja");
                horas = Convert.ToInt32(Console.ReadLine());
            } while (horas<0||horas>10);
            int CalculoDeSalario = med.CalculoSalario(antiguedadanos, salario);
            Console.WriteLine("Usted ha trabajado {0} años y gana {1} dolares la hora", antiguedadanos, CalculoDeSalario);
        }
    }
}
