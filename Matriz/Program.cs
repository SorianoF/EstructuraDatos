using Matriz;

public class Program
{
    static void Main()
    {
        Console.Write("Ingrese el número de filas: ");
        int filas = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el número de columnas: ");
        int columnas = int.Parse(Console.ReadLine());

        MatrizEnteros matriz = new MatrizEnteros(filas, columnas);

        matriz.IngresarValores();
        matriz.MostrarMatriz();
        matriz.MostrarMaximoMinimo();
    }
}