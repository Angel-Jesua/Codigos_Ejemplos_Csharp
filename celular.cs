using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class celular
    {
        public string Marca { get; set; }
        public string Tamaño { get; set; }

        public void Llamar(string numero)
        {
            Console.WriteLine($"Llamando al número {numero}...");
        }
        public void EnviarMensaje(string destinatario, string mensaje)
        {
            Console.WriteLine($"Enviando mensaje a {destinatario}: '{mensaje}'.");
        }
    }
}
