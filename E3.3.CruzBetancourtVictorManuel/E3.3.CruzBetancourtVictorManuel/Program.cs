using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3._3.CruzBetancourtVictorManuel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;  // Para que las figuras de las cartas puedan funcionar en la consola;
            Carta BlackJack = new Carta();  // Se declara el objeto de la clase Carta;
            BlackJack.Menú();  // Se manda llamar el metodo Menú;
        }
    }
}
