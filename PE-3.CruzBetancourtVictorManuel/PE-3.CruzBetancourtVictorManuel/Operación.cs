using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_3.CruzBetancourtVictorManuel
{
    class Operación  // Clase Operación;
    {
        public void Declarar()  // Declaración de un método público llamado Declarar;
        {
            Console.WriteLine("Juego de las Torres de Hanoi para todas las edades :)\n");
            Stack<int> Torre1 = new Stack<int>();  // Declaracion de una Pila de nombre Torre1; 
            Stack<int> Torre2 = new Stack<int>();  // Declaracion de una Pila de nombre Torre2;
            Stack<int> Torre3 = new Stack<int>();  // Declaracion de una Pila de nombre Torre3;
            Console.WriteLine("¿Cuántas discos desea en su torre? ");  // Se imprime un mensaje en la consola y se genera un salto de línea;
            int noDiscos = int.Parse(Console.ReadLine());  // Se lee el valor que presione el usuario y se le asigna a la variable indicada;
            for (int i = noDiscos; i > 0; i--)  // Declaración de un ciclo for que va en decremento;
            {
                Torre1.Push(i);  // Se llena la Torre1 con el numero de discos indicados por el usuario;
            }
            MoverFinal(noDiscos, Torre1, Torre3, Torre2);  // Se manda a llamar al método MoverFinal con sus parámetros;
            Imprimir(Torre1, Torre3, Torre2);  // Se manda a llamar al método Imprimir con sus parámetros;
            Console.ReadKey();  // Se genera una pausa en el programa; 
        }

        static void MoverInicio(Stack<int> Torre1, Stack<int> Torre3, Stack<int> Torre2)  // Declaración del método MoverInicio, el cuál está sobrecargado;
        {
            Imprimir(Torre1, Torre3, Torre2);  // Se manda a llamar al método Imprimir con sus parámetros; 
            Torre3.Push(Torre1.Pop());  // Se añade un valor a la Torre3, el cual es eliminado de la Torre1;
        }

        static void MoverFinal(int noDiscos, Stack<int> Torre1, Stack<int> Torre3, Stack<int> Torre2)  // Declaración del método MoverFinal, el cuál está sobrecargado;
        {

            if (noDiscos == 1)  // Si el número de discos es igual a 1, el disco se moverá directamente al final; 
            {
                MoverInicio(Torre1, Torre3, Torre2);  // Se manda a llamar al método MoverInicio con sus parámetros; 
                Imprimir(Torre1, Torre3, Torre2);  // Se manda a llamar al método Imprimir con sus parámetros;  
            }
            else  // Sino 
            {

                MoverFinal(noDiscos - 1, Torre1, Torre2, Torre3);  // Se manda a llamar al método Imprimir con sus parámetros;   
                MoverInicio(Torre1, Torre3, Torre2);  // Se manda a llamar al método Imprimir con sus parámetros;  
                MoverFinal(noDiscos - 1, Torre2, Torre3, Torre1);  // Se manda a llamar al método Imprimir con sus parámetros;  

            }
        }

        static void Imprimir(Stack<int> Torre1, Stack<int> Torre3, Stack<int> Torre2)  // Declaración del método Imprimir, el cuál está sobrecargado; 
        {
            Console.ReadKey();
            Console.Clear();  // Se limpia lo que hay en la consola en ese momento;
            Console.Write("Torre 1:\n ");  // Se imprime un mensaje en la consola;
            foreach (int item in Torre1)  // Los valores de Torre1 se le asignan a la variable item;
            {
                Console.Write(item + "\n ");  // Se imprime en consola cada uno de los valores asignados a la variable item; 
            }
            Console.WriteLine();  // Se genera un salto de línea;
            Console.Write("Torre 2:\n");  // Se imprime un mensaje en la consola; 
            foreach (int item in Torre2)  // Los valores de Torre2 se le asignan a la variable item; 
            {
                Console.Write(item + "\n ");  // Se imprime en consola cada uno de los valores asignados a la variable item;
            }
            Console.WriteLine();  // Se genera un salto de línea; 
            Console.Write("Torre 3:\n ");  // Se imprime un mensaje en la consola;
            foreach (int item in Torre3)  // Los valores de Torre3 se le asignan a la variable item;
            {
                Console.Write(item + "\n ");  // Se imprime en consola cada uno de los valores asignados a la variable item;
            }
        }                         
    }
}
