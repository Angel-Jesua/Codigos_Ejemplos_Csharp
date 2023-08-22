using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc;

            do
            {
                Console.WriteLine("Elige un objeto:");
                Console.WriteLine("1. Silla");
                Console.WriteLine("2. Perro");
                Console.WriteLine("3. Lápiz");
                Console.WriteLine("4. Celular");
                Console.WriteLine("5. Platillos");
                Console.WriteLine("6. Taza");
                Console.WriteLine("7. Reloj");
                Console.WriteLine("8. Salir");
                Console.Write("Opción: ");

                opc = Convert.ToInt32(Console.ReadLine());

                
            } while (opc < 0 || opc > 8);

            switch(opc)
            {
                case 1:
                    Console.WriteLine("Objeto seleccionado, silla");
                    Silla silla = new Silla();
                    silla.Material = "Madrea";
                    silla.Color = "Cafe";
                    silla.NumeroPatas = 4;
                    silla.Sentarse();
                    silla.Moverse();
                    silla.CambiarColor("Azul");
                    Console.WriteLine("La silla hecha de {0} y de color {1} tiene {2} patas",silla.Material, silla.Color, silla.NumeroPatas);
                    break;
                case 2:
                    Console.WriteLine("Objeto seleccionado, Perro");
                    Perro perro = new Perro();
                    perro.Nombre = "Luna";
                    perro.Edad = 1;
                    perro.Raza = "Terrier";
                    perro.Ladrar();
                    perro.Correr();
                    Console.WriteLine("Esa perra se llama {0}, tiene {1} año de edad y su raza es {2}", perro.Nombre, perro.Edad, perro.Raza);
                    break;
                case 3:
                    Console.WriteLine("Objeto seleccionado, Lapiz");
                    Lapiz lapiz = new Lapiz();
                    lapiz.Marca = "Mongol";
                    lapiz.Color = "Amarillo";
                    lapiz.Escribir("Hola");
                    lapiz.Afilar();
                    break;
                case 4:
                    Console.WriteLine("Objeto seleccionado, Celular");
                    celular Celular = new celular();
                    Celular.Marca = "Xiaomi";
                    Celular.Tamaño = "6.7 pulgadas";
                    Celular.Llamar("88432118");
                    Celular.EnviarMensaje("Camila", "¿Como estas?");
                    break;
                case 5:
                    Console.WriteLine("Objeto seleccionado, Platillos");
                    Platillos platillo = new Platillos();
                    platillo.ingredientes = "Pasta";
                    platillo.Nombre = "Spaguetti";
                    platillo.MostrarIngredientes();
                    platillo.Calentar();
                    break;
                case 6:
                    Console.WriteLine("Objeto seleccionado, Taza");
                    Taza taza = new Taza();
                    taza.Material = "Ceramica";
                    taza.Color = "Rojo";
                    taza.Llenar();
                    taza.Beber();
                    break;
                case 7:
                    Console.WriteLine("Objeto seleccionado, Reloj");
                    Reloj reloj = new Reloj();
                    reloj.Marca = "Casio";
                    reloj.MaterialCorrea = "Acero";
                    reloj.HoraActual = "7:00 AM";
                    reloj.MostrarHora();
                    reloj.AjustarHora("8:40 AM");
                    break;
                case 8:
                    Console.WriteLine("Usted ha decidido salir, presione una tecla"); Console.ReadKey();
                    break; 
            }
        }
    }
}
