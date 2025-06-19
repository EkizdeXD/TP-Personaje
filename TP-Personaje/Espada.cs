using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Personaje
{
    public class Espada : Equipo
    {
        public int Daño { get; set; }

        public override void Desequipar(Personaje jugador)
        {
            if (Equipado)
            {
                Equipado = false;
                jugador.Fuerza = jugador.Fuerza - Daño;
            }
        }

        public override void Equipar(Personaje jugador)
        {
            if (!Equipado)
            {
                Equipado = true;
                jugador.Fuerza = jugador.Fuerza + Daño;
            }
        }

        public override string ToString()
        {
            return $"Espada: Aumenta el daño en {Daño}.";
        }
    }
}
