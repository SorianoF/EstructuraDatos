using PracticaED;

public class Program
{
    static void Main()
    {
        Juego juego = new Juego();

        juego.AgregarJugador("Mario");
        juego.AgregarJugador("Axel");

        juego.Iniciar(5);

        Console.WriteLine("\nFin de la simulación.");
    }
}