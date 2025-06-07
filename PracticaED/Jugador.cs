using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaED
{
    public class Jugador
    {
        public string Nombre { get; set; }
        public List<Carta> Mano { get; private set; }

        public Jugador(string nombre)
        {
            Nombre = nombre;
            Mano = new List<Carta>();
        }

        public void RecibirCartas(List<Carta> cartas)
        {
            Mano.AddRange(cartas);
        }

        public void MostrarMano()
        {
            Console.WriteLine($"\nMano de {Nombre}:");
            foreach (var carta in Mano)
            {
                Console.WriteLine($" - {carta}");
            }
        }
    }
}
