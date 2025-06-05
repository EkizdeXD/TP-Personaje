using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Personaje
{
    public class Casco : Equipo
    {
        public void AumentarDefensa(Personaje personaje)
        {
            Console.WriteLine("Ingrese el valor para la Defensa del Casco");
            int DefensaAumentada = int.Parse(Console.ReadLine());

            personaje.Defensa = personaje.Defensa + DefensaAumentada;
        }
        public override void Desequipar(Personaje jugador)
        {
            Equipado = false;
        }

        public override void Equipar(Personaje jugador)
        {
            Equipado = true;
        }
    }
}
