using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_4_3.CruzBetancourtVictorManuel
{
    class Program
    {
        static void Main(string[] args)
        {
            var vertices = new[] { "A", "B", "C", "G", "F", "D", "E" };
            var arist = new[]{Tuple.Create("A","B"), Tuple.Create("B","G"),
                Tuple.Create("C","B"), Tuple.Create("D","C"), Tuple.Create("C","G"),
                Tuple.Create("D","F"), Tuple.Create("D","E"), Tuple.Create("F","E")};

            var arist2 = new[]{Tuple.Create("A","B"), Tuple.Create("B","C"),
                Tuple.Create("G","B"), Tuple.Create("F","G"), Tuple.Create("C","G"),
                Tuple.Create("D","F"), Tuple.Create("D","E"), Tuple.Create("F","E")};

            var grafo = new Grafo<string>(vertices, arist);
            var grafo2 = new Grafo<string>(vertices, arist2);
            var algoritmo = new Algoritmo();

            var VertInicial = "A";
            var CamiMasCort = algoritmo.CamiMasCortFunc(grafo, VertInicial);
            foreach (var vert in vertices)
                Console.WriteLine("Camino Más Corto a {0}: {1}", vert, string.Join(" --> ", CamiMasCort(vert)));
            Console.WriteLine(string.Join(" --> ", algoritmo.BFS(grafo, "A")));
            Console.WriteLine(string.Join(" --> ", algoritmo.BFS(grafo2, "A")));
            Console.ReadKey();
        }
    }
}
