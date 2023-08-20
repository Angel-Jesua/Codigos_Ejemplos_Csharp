using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion_Figuras
{
    internal class Abstraccion_Figuras
    {
        static void Main(string[] args)
        {
            SByte opc;
            Calculo_Area calculadora = new Calculo_Area();
            do
            {
                Console.WriteLine("Elija que figura geometrica desea calcular su area");
                Console.WriteLine("1.-Cuadrado 2.-Triangulo 3.-Circulo");
                opc = Convert.ToSByte(Console.ReadLine());
            } while (opc<1||opc>3);

            switch (opc)
            {
                case 1:
                    double lado;
                    double area;
                    Console.WriteLine("Coloque el lado del cuadrado");
                       lado = Convert.ToDouble(Console.ReadLine());
                    area = calculadora.CalcularAreaCuadrado(lado);
                    Console.WriteLine("El Area del cuadrado es: {0}", area);
                    break;

                case 2:
                    double basee;
                    double altura;
                    Console.WriteLine("Coloque la base del triangulo");
                    basee = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Coloque la altura del triangulo");
                    altura = Convert.ToDouble(Console.ReadLine());
                    area = calculadora.CalcularAreaTriangulo(basee, altura);
                    Console.WriteLine("El area del triangulo es: {0}", area);
                    break;
                case 3:
                    double radio;
                    Console.WriteLine("Coloque el radio del circulo");
                    radio = Convert.ToDouble(Console.ReadLine());
                    area = calculadora.CalcularAreaCirculo(radio);
                    Console.WriteLine("El area del triangulo es: {0}", area);
                    break;
            }
            Console.Write("Presione una tecla"); Console.ReadKey();
        }
    }
}
