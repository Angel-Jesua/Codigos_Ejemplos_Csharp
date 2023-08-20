using System;

namespace Abstraccion_Figuras
{
    internal class Calculo_Area : Area
    {
        private double lado;
        private double basee;
        private double altura;
        private double radio;

        public Calculo_Area()
        {
        }

        public Calculo_Area(double lado, double basee, double altura, double radio)
        {
            this.lado = lado;
            this.basee = basee;
            this.altura = altura;
            this.radio = radio;
        }

        public override double CalcularAreaCirculo(double radio)
        {
            return Math.PI * radio * radio;
        }

        public override double CalcularAreaCuadrado(double lado)
        {
            return lado * lado;
        }

        public override double CalcularAreaTriangulo(double basee, double altura)
        {
            return (basee * altura) / 2;
        }
    }
}
