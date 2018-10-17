using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC3_2.CruzBetancourtVictorManuel
{
    class Program
    {
        static void Main(string[] args)
        {  // Llave de apertura del main :);
            Queue Cola = new Queue();  // Inicialización de la variable Cola por medio de la clase Queue;
            // Enqueue: Agrega un elemento al final de la cola, este elemento puede ser cualquier tipo;
            Cola.Enqueue("JP");  // Se agrega el elemento tipo String "JP";
            Cola.Enqueue(1211);  // Se agrega el elemento tipo int 1211;
            Cola.Enqueue(false);  // Se agrega el elemento tipo bool "false";
            foreach (var item in Cola)  // A través de un foreach se le asignan los valores de la Cola a la variable item;
            {  // Llave de apertura del ciclo foreach :);
                Console.WriteLine(item);  // Se visualiza la variable item y se genera un salto de línea;
            }  // Llave de cierre del ciclo foreach :);
            Console.ReadKey();  // Detiene por un momento el programa hasta que el usuario presione cualquier tecla;
            Console.WriteLine();  // Se genera un salto de línea;
            Cola.Dequeue();  // Dequeue: Elimina el primer elemento de la cola
            foreach (var item in Cola)  // A través de un foreach se le asignan los valores de la Cola a la variable item;
            {  // Llave de apertura del ciclo foreach :);
                Console.WriteLine(item);  // Se visualiza la variable item y se genera un salto de línea;
            }  // Llave de cierre del ciclo foreach :);
            Console.ReadKey();
            Console.WriteLine();  // Se genera un salto de línea;
            Cola.TrimToSize();  //TrimToSize: Restringe la capacidad de la cola con el número de elementos actuales de la cola
            Console.ReadKey();  // Detiene por un momento el programa hasta que el usuario presione cualquier tecla;
        }  // Llave de cierre del main :);
    }
}
