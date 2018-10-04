using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_2.Cruz_Betancourt_Victor_Manuel
{
    class Métodos
    {
        public int MínimoSucesión(int[] Sucesión, int Índice, int Mínimo)
        {
            if (Índice != Sucesión.Length)
            {
                if (Sucesión[Índice] < Mínimo)
                {
                    Mínimo = MínimoSucesión(Sucesión, Índice + 1, Sucesión[Índice]);
                }
                else
                {
                    Mínimo = MínimoSucesión(Sucesión, Índice + 1, Mínimo);
                }
            }
            return Mínimo;
        }
        public int MáximoSucesión(int[] Sucesión, int Índice, int Máximo)
        {
            if (Índice != Sucesión.Length)
            {
                if (Sucesión[Índice] > Máximo)
                {
                    Máximo = MáximoSucesión(Sucesión, Índice + 1, Sucesión[Índice]);
                }
                else
                {
                    Máximo = MáximoSucesión(Sucesión, Índice + 1, Máximo);
                }
            }
            return Máximo;
        }
        public void SucesiónInvertida(int[] Sucesión, int Principio, int Fin)
        {
            if (Principio < Fin)
            {
                int Auxiliar = Sucesión[Principio];
                Sucesión[Principio] = Sucesión[Fin];
                Sucesión[Fin] = Auxiliar;
                SucesiónInvertida(Sucesión, Principio + 1, Fin - 1);
            }
        }
    }
}
