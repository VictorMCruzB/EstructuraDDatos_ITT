using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace E2_2_CruzBetancourtVictorManuel
{
    class Fibonacci
    {
        public void For()
        {
            int Número = 1;
            int Temporal = 0;
            int Resultado = 1; 
            Console.WriteLine("Método For\n¿Cuántos números de Fibonacci desea calcular?");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Los números solicitados son los siguientes:");
            Console.WriteLine("Valor número 1: 0");
            for (int i = 0; i < n-1; i++)
            {
                Console.WriteLine("Valor número {0}: {1}",i+2, Resultado);
                Resultado = Número + Temporal;
                Temporal = Número;
                Número = Resultado;
            }
            Console.WriteLine();
        }

        public int Recursivo(int Número)
        {
                if (Número < 2)
                {
                    return Número;
                }
                else
                {
                    return Recursivo(Número - 1) + Recursivo(Número - 2);
                }
        }

        public void Recursivo2()
        {
            Console.WriteLine("Método Recursivo\n¿Cuántos números de Fibonacci desea calcular?");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Los numeros solicitados son los siguientes:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Valor número {0}: {1}", i + 1,Recursivo(i));
            }
        }

        public void Tiempo()
        {
            Stopwatch tiempo = new Stopwatch(); tiempo.Start();
            For();
            tiempo.Stop();
            Console.WriteLine("Tiempo de ejecución del programa {0}\n", tiempo.Elapsed.ToString());
            Stopwatch tiempo2 = new Stopwatch(); tiempo2.Start();
            Recursivo2();
            tiempo2.Stop();
            Console.WriteLine("\nTiempo de ejecución del programa {0}", tiempo2.Elapsed.ToString());
        }
    }
}
