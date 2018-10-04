using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_2.Cruz_Betancourt_Victor_Manuel
{
    class Program
    {
        static void Main(string[] args)
        {
            char opc;
            do
            {
                Console.WriteLine("¿Cúantos números tiene su sucesión?");
                int n = int.Parse(Console.ReadLine());
                int[] Sucesión = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Valor número {0} de la sucesión", i + 1);
                    Sucesión[i] = int.Parse(Console.ReadLine());
                }
                Métodos Objeto = new Métodos();
                Console.WriteLine("El valor mínimo de la sucesion es {0}", Objeto.MínimoSucesión(Sucesión, 0, Sucesión[0]));
                Console.WriteLine("El valor máximo de la sucesion es {0}", Objeto.MáximoSucesión(Sucesión, 0, Sucesión[0]));
                Objeto.SucesiónInvertida(Sucesión, 0, Sucesión.Length - 1);
                Console.WriteLine("La sucesión invertida es:");
                for (int i = 0; i < Sucesión.Length; i++)
                {
                    Console.WriteLine(Sucesión[i]);
                }
                Console.WriteLine("¿Desea ingresar otra sucesión?\n1: Si\n2: No");
                opc = char.Parse(Console.ReadLine());
            } while (opc == '1');
            Console.ReadKey();
        }
    }
}
