using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Personaje
{
    public interface IEquipable
    {
        void Equipar(Personaje jugador);
        void Desequipar(Personaje jugador);
    }
}
