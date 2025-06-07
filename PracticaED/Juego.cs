using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaED
{
    public class Juego
    {
        private List<Jugador> jugadores;
        private Baraja baraja;

        public Juego()
        {
            jugadores = new List<Jugador>();
            baraja = new Baraja();
        }

        public void AgregarJugador(string nombre)
        {
            jugadores.Add(new Jugador(nombre));
        }

        public void Iniciar(int cartasPorJugador)
        {
            baraja.Barajar();

            foreach (var jugador in jugadores)
            {
                var mano = baraja.Repartir(cartasPorJugador);
                jugador.RecibirCartas(mano);
            }

            MostrarEstado();
        }

        private void MostrarEstado()
        {
            foreach (var jugador in jugadores)
            {
                jugador.MostrarMano();
            }
        }
    }
}
