using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_4_3.CruzBetancourtVictorManuel
{
    class Grafo<T>
    {
        public Grafo() { }
        public Grafo(IEnumerable<T> Vertis, IEnumerable<Tuple<T, T>> Arist)
        {
            foreach (var Vert in Vertis)
                AñadVert(Vert);

            foreach (var Ari in Arist)
                AñadAri(Ari);
        }

        public Dictionary<T, HashSet<T>> ListAd  = new Dictionary<T, HashSet<T>>();

        public void AñadVert(T vert)
        {
            ListAd[vert] = new HashSet<T>();
        }

        public void AñadAri(Tuple<T, T> Ari)
        {
            if (ListAd.ContainsKey(Ari.Item1) && ListAd.ContainsKey(Ari.Item2))
            {
                ListAd[Ari.Item1].Add(Ari.Item2);
                ListAd[Ari.Item2].Add(Ari.Item1);
            }
        }
    }
}
