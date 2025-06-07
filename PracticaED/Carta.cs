using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaED
{
    public class Carta
    {
        public string Palo { get; set; }
        public string Valor { get; set; }

        public Carta(string valor, string palo) 
        {
            Valor = valor;
            Palo = palo;   
        }

        public override string ToString()
        {
            return $"{Valor} de {Palo}";  
        }
    }
}
