using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Personaje
{
    public class Inventario
    {
        public Personaje Jugador { get; set; } = null!;

        public List<Item> Items { get; set; } = new List<Item>();

        public void AgregarItem(Item item)
        {
            Items.Add(item);
            item.Inventario = this;
        }

        public void QuitarItem(Item item)
        {
            Items.Remove(item);
            item.Inventario = null;
        }
    }
}
