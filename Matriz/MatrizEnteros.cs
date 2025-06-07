using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    public class MatrizEnteros
    {
        private int[,] matriz;
        private int filas;
        private int columnas;

        public MatrizEnteros(int filas, int columnas)
        {
            this.filas = filas;
            this.columnas = columnas;
            matriz = new int[filas, columnas];
        }

        public void IngresarValores()
        {
            Console.WriteLine("\nIngrese los valores de la matriz:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void MostrarMatriz()
        {
            Console.WriteLine("\nMatriz ingresada:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public void MostrarMaximoMinimo()
        {
            int max = matriz[0, 0];
            int min = matriz[0, 0];
            int filaMax = 0, colMax = 0;
            int filaMin = 0, colMin = 0;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (matriz[i, j] > max)
                    {
                        max = matriz[i, j];
                        filaMax = i;
                        colMax = j;
                    }

                    if (matriz[i, j] < min)
                    {
                        min = matriz[i, j];
                        filaMin = i;
                        colMin = j;
                    }
                }
            }

            Console.WriteLine($"\n Valor máximo: {max} en la posición [{filaMax},{colMax}]");
            Console.WriteLine($" Valor mínimo: {min} en la posición [{filaMin},{colMin}]");
        }
    }
}
