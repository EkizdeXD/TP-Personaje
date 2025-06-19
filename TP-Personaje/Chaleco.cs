using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Personaje
{
    public class Chaleco : Equipo
    {
        public int Defensa { get; set; }

        public override void Desequipar(Personaje jugador)
        {
            if (Equipado)
            {
                Equipado = false;
                jugador.Defensa = jugador.Defensa - Defensa;
            }
        }

        public override void Equipar(Personaje jugador)
        {
            if (!Equipado)
            {
                Equipado = true;
                jugador.Defensa = jugador.Defensa + Defensa;
            }
        }

        public override string ToString()
        {
            return $"Chaleco: Aumenta la defensa en {Defensa}.";
        }
    }
}
