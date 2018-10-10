using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_1.CruzBetancourtVictorManuel
{
    class Program
    {
        static void Main(string[] args)
        {
            int Cantidad;  // Se declara una variable de tipo int llamada Cantidad;
            Console.WriteLine("Ingrese el número de clases y alumnos");  // Se pide que se ingrese el número de clases y alumnos;
            Cantidad = int.Parse(Console.ReadLine());  // Se lee el valor ingresado por el usuario y se le asigna a la variable Cantidad;
            Carrera Clase = new Carrera();  // Se declara un objeto llamado Clase;
            Clase.Captura(Cantidad);  // A través del objeto llamado Clase se manda a llamar al método de nombre Captura de la clase Carrera;
            Console.ReadKey();  // Finaliza el código :)
        }
    }
}
