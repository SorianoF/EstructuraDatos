using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaED
{
    public class Baraja
    {
        private List<Carta> cartas;
        private static readonly string[] Palos = { "Corazones", "Diamantes", "Tréboles", "Picas" };
        private static readonly string[] Valores = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

        public Baraja() 
        {
            cartas = new List<Carta>();
            CrearBaraja();
        }

        private void CrearBaraja()
        {
            foreach (var palo in Palos)
            {
                foreach (var valor in Valores)
                {
                    cartas.Add(new Carta(valor, palo));
                }
            }
        }

        public void Barajar()
        {
            Random rng = new Random();
            for (int i = cartas.Count - 1; i > 0; i--)
            {
                int j = rng.Next(i+1);
                var temp = cartas[i];
                cartas[i] = cartas[j];
                cartas[j] = temp; 
            }
        }

        public List<Carta> Repartir(int cantidad)
        {
            List<Carta> mano = cartas.GetRange(0, cantidad);
            cartas.RemoveRange(0, cantidad);
            return mano;
        }
    }
}
