﻿using System;  // using System;
using System.Collections.Generic;  // using System.Collections.Generic;
using System.Linq;  // using System,Linq;
using System.Text;  // using System.Text;
using System.Threading.Tasks;  // using System,Threading.Tasks;
// Espacio entre lïneas;
namespace _5_3.CruzBetancourtVictorManuel  // Nombre de la práctica;
{  // Se abre la llave;
    class Program  // Clase Program;
    {  // Se abre la llave;
        static void Main(string[] args)  // Clase Main;
        {  // Se abre la llave;
            CapturaDatos CP = new CapturaDatos();  // Se crea un objeto de la clase CapturaDatos, que lleva pro nombre CP;
            CP.Capturar();  // Se manda a llamar al método Capturar, por medio del objeto CP;
            Console.ReadKey();  // Fin del programa;
        }  // Se cierra la llave;
    }  // Se cierra la llave;
}  // Se cierra la llave;