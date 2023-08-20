using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Basico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eleccion;
            Mascota mas = new Mascota("woof", "miau");
            do
            {
                Console.WriteLine("Ingrese que sonido de mascota quiere oir");
                Console.WriteLine("1.- Perro 2.- Gato");
                eleccion = Convert.ToInt32(Console.ReadLine());
            } while (eleccion < 1 || eleccion > 2);

            switch(eleccion){
                case 1:
                    mas.SonidoDePerro();
                    Console.WriteLine("Presione una tecla");  Console.ReadKey();
                    break;
                case 2:
                    mas.SonidoDeGato();
                    Console.WriteLine("Presione una tecla");  Console.ReadKey();
                    break;
            }
        }
    }
}
