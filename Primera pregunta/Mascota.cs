﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Basico
{
    internal class Mascota
    {
        string perro = "woof";

        string gato = "miau";
        public Mascota(string perro, string gato)
        {
            this.perro = perro;
            this.gato = gato;
        }
        public void SonidoDePerro()
        {
            Console.WriteLine("el perro le hace {0}", perro);
        }
        public void SonidoDeGato()
        {
            Console.WriteLine("El gato le hace {0}", gato);
        }


    }
}
