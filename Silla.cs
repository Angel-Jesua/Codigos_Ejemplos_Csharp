using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Silla
    {
        public string Material { get; set; }
        public string Color { get; set; }
        public int NumeroPatas { get; set; }

        public void Sentarse()
        {
            Console.WriteLine("Alguien se sentó en la silla.");
        }

        public void Moverse()
        {
            Console.WriteLine("La silla se movió ligeramente.");
        }

        public void CambiarColor(string nuevoColor)
        {
            Color = nuevoColor;
            Console.WriteLine($"El color de la silla se cambió a {nuevoColor}.");
        }
    }

}

