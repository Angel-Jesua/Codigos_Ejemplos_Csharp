using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Perro
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Raza { get; set; }

        public void Ladrar()
        {
            Console.WriteLine("¡Woof woof!");
        }

        public void Correr()
        {
            Console.WriteLine("El perro está corriendo a toda velocidad.");
        }


    }
}
