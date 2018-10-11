using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC3_1.CruzBetancourtVictorManuel
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack Nombres = new Stack();
            Nombres.Push("Victor");
            Nombres.Push("Manuel");
            Nombres.Push("Chuleta");
            Nombres.Push("Elden");
            Nombres.Push("David");
            Nombres.Push(4);
            Nombres.Push(8);
            foreach (var item in Nombres)
            {
                Console.WriteLine(item);
            }
            // Propiedad Contains: Busca si contiene el elemento solicitado;
            if (Nombres.Contains("Victor"))
            {
                Console.WriteLine("\nSi lo contiene");
            }
            // Propiedad GetType: Obtiene el tio de dato de la lista e imrprime un true si la lista es un tipo Stack o false en caso contrario;
            Console.WriteLine((Nombres.GetType() == typeof(Stack)));
            // Propiedad ToString: Se hace una condición para mostrar si el elemento superior de la lista es igual al caracter '8';
            if (Nombres.Peek().ToString() == "8")
            {
                Console.WriteLine(Nombres.Peek());
            }
            Console.WriteLine("");
            // Propiedad ToArray: Se hace una copia de la primera lista haciendo que se almacena al revés (de arriba a abajo) a comparación de la primera lista;
            Stack Gemelo = new Stack(Nombres.ToArray());
            foreach (var item2 in Gemelo)
            {
                Console.WriteLine(item2);
            }
            Console.WriteLine("");
            // Propiedad GetEnumerator;
            IEnumerator e = Nombres.GetEnumerator();
            while (e.MoveNext())
            {
                Console.WriteLine(e.Current);
            }
            Console.ReadKey();
        }
    }
}
