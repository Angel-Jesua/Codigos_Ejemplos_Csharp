using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    internal class Platillos
    {
        public string ingredientes { get; set; }
        public string Nombre { get; set; }

        public void MostrarIngredientes()
        {
            Console.WriteLine($"Los ingredientes del platillo {Nombre} es: {ingredientes}.");
        }
        public void Calentar()
        {
            Console.WriteLine($"Calentando el platillo {Nombre}.");
        }
    }

}
