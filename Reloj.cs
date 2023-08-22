using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Reloj
    {
        public string Marca { get; set; }
        public string MaterialCorrea { get; set; }

        public string HoraActual { get; set; }
        public void MostrarHora()
        {
            Console.WriteLine($"La hora actual del reloj {Marca} es {HoraActual}.");
        }
        public void AjustarHora(string nuevaHora)
        {
            HoraActual = nuevaHora;
            Console.WriteLine($"Se ajustó la hora del reloj a {nuevaHora}.");
        }

    }
}
