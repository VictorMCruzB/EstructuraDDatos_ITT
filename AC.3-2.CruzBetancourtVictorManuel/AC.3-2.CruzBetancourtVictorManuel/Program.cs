using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC._3_2.CruzBetancourtVictorManuel
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack Nombres = new Stack();  // Creación de la Pila de nombre "Nombres";
            Nombres.Push("Victor");
            Nombres.Push("Manuel");
            Nombres.Push("Chuleta");
            Nombres.Push("Elden");
            Nombres.Push("David");
            Nombres.Push(4.38);
            Nombres.Push(8f);
            Nombres.Push(true);
            Nombres.Push(23);
            Nombres.Push(false);
            int contador = Nombres.Count;  // Creación de la variable contador, a la cual se le asigna el número que tiene cada elemento en la pila;
            foreach (var item in Nombres)  // Inicialización de un foreach para poder desplegar cada uno de los elementos que se encuentran en la pila "Nombres", por medio de la variable item;
            {
                Console.WriteLine("{0}\nTipo: {1}\nPosición: {2}",item, item.GetType(),contador--);  // Se despliegan los elementos de la pila, su tipo de dato y su posición con la variable item, el método GetType() y un contador;
                
            }
            Console.ReadKey();  // Finaliza el programa;
        }
    }
}
