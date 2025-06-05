using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Personaje
{
    public abstract class Equipo : Item, IEquipable
    {
        public bool Equipado { get; set; }

        public abstract void Equipar(Personaje jugador);
        public abstract void Desequipar(Personaje jugador);
    }
}
