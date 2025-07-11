﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Personaje
{
    public class Personaje
    {
        public string Color { get; set; } = null!;
        public int Vida { get; set; }
        public int Mana { get; set; }
        public int Defensa { get; set; }
        public int Fuerza { get; set; }
        public int VidaMax { get; set; }
        public int ManaMax { get; set; }
        public Inventario Inventario { get; set; } = new Inventario();

        public void CambiarColor(string NuevoColor)
        {
            if (NuevoColor != Color)
            {
                Color = NuevoColor;
            }
        }

        public int RecibirDaño(int FuerzaDeAtaque)
        {
            int Daño = FuerzaDeAtaque - Defensa;
            if (Daño > 0)
            {
                Vida = Vida - Daño;
                return Daño;
            }
            return 0;
        }

        public int Atacar(Personaje personaje)
        {
            if (Mana > 0)
            {
                Mana = Mana - 1;
                return personaje.RecibirDaño(Fuerza);
            }
            return 0;
        }
    }
}
