using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2_1Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Métodos Factorial = new Métodos();
            TimeSpan stop;
            TimeSpan start = new TimeSpan(DateTime.Now.Ticks);
            stop = new TimeSpan(DateTime.Now.Ticks);
            TimeSpan parar;
            TimeSpan iniciar = new TimeSpan(DateTime.Now.Ticks);
            parar = new TimeSpan(DateTime.Now.Ticks);
            Console.WriteLine("Ciclo for\nFactorial #6 = {0}\nTiempo de Ejecución: {1} Segundos\n\nRecursividad\nFactorial #6 = {2}\nTiempo de ejecución: {3} Segundos", Factorial.CalcularFactorial(), stop.Subtract(start).TotalSeconds, Factorial.CalcularFactorialRecursividad(), parar.Subtract(iniciar).TotalSeconds);
            Console.ReadKey();
        }
    }
}
