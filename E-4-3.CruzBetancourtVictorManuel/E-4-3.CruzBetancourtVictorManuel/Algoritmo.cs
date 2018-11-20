using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_4_3.CruzBetancourtVictorManuel
{
    class Algoritmo
    {
        public Func<T, IEnumerable<T>> CamiMasCortFunc<T>(Grafo<T> grafo, T start)
        {
            var Anterior = new Dictionary<T, T>();

            var queue = new Queue<T>();
            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                var vert = queue.Dequeue();
                foreach (var Vecino in grafo.ListAd[vert])
                {
                    if (Anterior.ContainsKey(Vecino))
                        continue;

                    Anterior[Vecino] = vert;
                    queue.Enqueue(Vecino);
                }
            }

            Func<T, IEnumerable<T>> CamiMasCort = v =>
            {
                var Camino = new List<T> { };

                var Actual = v;
                while (!Actual.Equals(start))
                {
                    Camino.Add(Actual);
                    Actual = Anterior[Actual];
                };

                Camino.Add(start);
                Camino.Reverse();

                return Camino;
            };

            return CamiMasCort;
        }

        public HashSet<T> BFS<T>(Grafo<T> grafo, T start)
        {
            var Visit = new HashSet<T>();

            if (!grafo.ListAd.ContainsKey(start))
                return Visit;

            var queue = new Queue<T>();
            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                var Vert = queue.Dequeue();

                if (Visit.Contains(Vert))
                    continue;

                Visit.Add(Vert);

                foreach (var Vecino in grafo.ListAd[Vert])
                    if (!Visit.Contains(Vecino))
                        queue.Enqueue(Vecino);
            }

            return Visit;
        }
    }
}
