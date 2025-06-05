using System.Security.Cryptography.X509Certificates;
using TP_Personaje;

Personaje Jugador = new();
Personaje Bot = new();
Inventario Inventario = new Inventario();

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

    personaje.Inventario.Jugador = personaje;

    PocionVida pocionVida = CrearPocionVida();
    PocionMana pocionMana = CrearPocionMana();

    personaje.Inventario.AgregarItem(pocionVida);
    personaje.Inventario.AgregarItem(pocionMana);
}

PocionVida CrearPocionVida()
{
    PocionVida PocionVida = new();
    Console.WriteLine("Ingrese El Valor Mínimo Para La Vida");
    PocionVida.Minimo = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese El Valor Máximo Para La Vida");
    PocionVida.Maximo = int.Parse(Console.ReadLine());
    return PocionVida;
}

PocionMana CrearPocionMana()
{
    PocionMana PocionMana = new();
    Console.WriteLine("Ingrese El Valor Mínimo Para El Maná");
    PocionMana.Minimo = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese El Valor Máximo Para El Maná");
    PocionMana.Maximo = int.Parse(Console.ReadLine());
    return PocionMana;
}

void MostrarInventario(Personaje personaje)
{
    int i = 0;
    Console.WriteLine("Inventario:");
    foreach (Item item in personaje.Inventario.Items)
    {
        i = i + 1;
        Console.WriteLine($"{i}: {item}");
    }
}

CargarPersonaje(Jugador);
Console.Clear();
CargarPersonaje(Bot);
Console.Clear();

while (Jugador.Vida > 0 && Bot.Vida > 0)
{
    Console.WriteLine("Jugador HUD");
    MostrarInventario(Jugador);
    Console.WriteLine($"Color: {Jugador.Color} | Vida: {Jugador.Vida} | Maná: {Jugador.Mana} | Defensa: {Jugador.Defensa} | Fuerza: {Jugador.Fuerza}");
    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");
    Console.WriteLine("Bot HUD");
    Console.WriteLine($"Color: {Bot.Color} | Vida: {Bot.Vida} | Maná: {Bot.Mana} | Defensa: {Bot.Defensa} | Fuerza: {Bot.Fuerza}");
    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");
    Console.WriteLine($"1 - Cambiar Color / 2 - Atacar / 3 - Recibir Daño / 4 - Usar Ítem / 5 - Equipar Ítem / 6 - Desequipar Ítem");
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
            MostrarInventario(Jugador);
            int Elección2 = int.Parse(Console.ReadLine());
            Pocion pocionSeleccionada = Jugador.Inventario.Items[Elección2 - 1] as Pocion;
            pocionSeleccionada.Usar(Jugador);
            Jugador.Inventario.QuitarItem(pocionSeleccionada);
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