using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Taza
    {
        public string Material { get; set; }
        public string Color { get; set; }

        public void Llenar()
        {
            Console.WriteLine("Llenando la taza con líquido.");
        }

        public void Beber()
        {
            Console.WriteLine("Bebiendo de la taza.");
        }

    }
}
