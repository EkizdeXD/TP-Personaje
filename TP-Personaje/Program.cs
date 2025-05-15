using TP_Personaje;

Personaje Jugador = new();
Personaje Bot = new();
PocionVida PocionVida = new();
PocionMana PocionMana = new();

void CargarPersonaje(Personaje personaje)
{
    Console.WriteLine("Ingrese Color");
    personaje.Color = Console.ReadLine();

    Console.WriteLine("Ingrese Vida");
    personaje.Vida = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese Mana");
    personaje.Mana = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese Defensa");
    personaje.Defensa = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese Fuerza");
    personaje.Fuerza = int.Parse(Console.ReadLine());

    personaje.VidaMax = personaje.Vida;

    personaje.ManaMax = personaje.Mana;
}

CargarPersonaje(Jugador);
Console.Clear();
CargarPersonaje(Bot);
Console.Clear();

while (Jugador.Vida > 0 && Bot.Vida > 0)
{
    Console.WriteLine("Jugador HUD");
    Console.WriteLine($"Color: {Jugador.Color} | Vida: {Jugador.Vida} | Maná: {Jugador.Mana} | Defensa: {Jugador.Defensa} | Fuerza: {Jugador.Fuerza}");
    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");
    Console.WriteLine("Bot HUD");
    Console.WriteLine($"Color: {Bot.Color} | Vida: {Bot.Vida} | Maná: {Bot.Mana} | Defensa: {Bot.Defensa} | Fuerza: {Bot.Fuerza}");
    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");
    Console.WriteLine($"1 - Cambiar Color / 2 - Atacar / 3 - Recibir Daño / 4 - Usar Poción");
    Console.WriteLine();

    int Elección = int.Parse(Console.ReadLine());
    Console.Clear();

    switch (Elección)
    {
        case 1:
            string NuevoColor;
            Console.WriteLine("Ingrese Nuevo Color");
            NuevoColor = Console.ReadLine();
            Jugador.CambiarColor(NuevoColor);
            break;
        case 2:
            Jugador.Atacar(Bot);
            break;
        case 3:
            int FuerzaDeAtaque;
            Console.WriteLine("Ingrese Daño Recibido");
            FuerzaDeAtaque = int.Parse(Console.ReadLine());
            Jugador.RecibirDaño(FuerzaDeAtaque);
            break;
        case 4:
            Console.WriteLine("1 - Poción De Vida / 2 - Poción De Maná");
            int Elección2 = int.Parse(Console.ReadLine());
            if (Elección2 == 1)
            {
                Console.WriteLine("Ingrese El Valor Mínimo Para La Vida");
                PocionVida.Minimo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese El Valor Máximo Para La Vida");
                PocionVida.Maximo = int.Parse(Console.ReadLine());
                PocionVida.Usar(Jugador);
            }
            else if (Elección2 == 2)
            {
                Console.WriteLine("Ingrese El Valor Mínimo Para El Maná");
                PocionMana.Minimo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese El Valor Máximo Para El Maná");
                PocionMana.Maximo = int.Parse(Console.ReadLine());
                PocionMana.Usar(Jugador);
            }
            break;
    }
}

if (Jugador.Vida <= 0)
{
    Console.WriteLine("Moriste XD");
}
else if (Bot.Vida <= 0)
{
    Console.WriteLine("Ganaste :D");
}

Console.ReadKey();