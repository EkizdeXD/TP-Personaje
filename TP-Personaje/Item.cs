using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Personaje
{
    public abstract class Item
    {
        public Inventario? Inventario { get; set; }

        public abstract int Usar(Personaje Jugador);
    }
}
