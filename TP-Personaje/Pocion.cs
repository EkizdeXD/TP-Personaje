using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TP_Personaje
{
    public abstract class Pocion
    {
        public int Minimo { get; set; }
        public int Maximo { get; set; }

        public abstract int Usar(Personaje Jugador);
    }
}