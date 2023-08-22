using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Lapiz
    {
        public string Marca { get; set; }
        public string Color { get; set; }

        public void Escribir(string texto)
        {
            Console.WriteLine($"Se escribió: '{texto}' con el lápiz {Marca}.");

        }

        public void Afilar()
        {
            Console.WriteLine("El lápiz ha sido afilado.");
        }
    }
}
