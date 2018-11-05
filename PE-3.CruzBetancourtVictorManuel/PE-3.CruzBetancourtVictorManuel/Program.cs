using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_3.CruzBetancourtVictorManuel
{
    class Program  // Clase Program
    {
        static void Main(string[] args)  // Main
        {
            Operación tdh = new Operación();  // Creación de un objeto para llamar a los métodos de la clase Operación;
            tdh.Declarar();  // LLamada del método Declarar a través del objeto tdh que significa torres de hanoi;
            Console.ReadKey();  // Se genera una pausa en el programa;
        }
    }
}
