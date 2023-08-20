using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion_Figuras
{
    public abstract class Area
    {
        public abstract double CalcularAreaCuadrado(double lado);
        public abstract double CalcularAreaTriangulo(double basee, double altura);
        public abstract double CalcularAreaCirculo(double radio);

    }
}
