using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string palindrome;
            string caracter;
            string invertido;
            invertido = "";
            do
            {
                Console.Write("Introduzca un número de 5 dígitos: ");
                palindrome = Console.ReadLine();
                i = palindrome.Length;
                if (i != 5)
                {
                    Console.WriteLine("No cumple con los requisitos");
                }
            } while (i != 5);
            for (int j = 4; j >= 0; j--)
            {
                caracter = palindrome.Substring(j, 1);
                invertido = invertido + caracter; ;
            }
            if (palindrome == invertido)
            {
                Console.WriteLine("Si es un Palindrome");
            }
            else
            {
                Console.WriteLine("No es un Palindrome");
            }
            Console.ReadKey();
        }
    }
}
