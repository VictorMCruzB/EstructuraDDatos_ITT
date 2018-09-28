using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2_1Factorial
{
    class Métodos
    {
        public int CalcularFactorial(int n = 6)
        {
            int Factorial = 1;
            for (int contador = n; contador >= 1; contador--)
            {
                Factorial = Factorial * contador;
            }
            return Factorial;
        }

        public int CalcularFactorialRecursividad(int n = 6)
        {
            if (n == 0)
                return 1;
            return n * CalcularFactorialRecursividad(n - 1);
        }
    }
}
