using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Personaje
{
    public class Espada : Equipo
    {
        public void AumentarDaño(Personaje personaje)
        {
            Console.WriteLine("Ingrese el valor para el Daño de la Espada");
            int DañoAumentado = int.Parse(Console.ReadLine());

            personaje.Fuerza = personaje.Fuerza + DañoAumentado;
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
