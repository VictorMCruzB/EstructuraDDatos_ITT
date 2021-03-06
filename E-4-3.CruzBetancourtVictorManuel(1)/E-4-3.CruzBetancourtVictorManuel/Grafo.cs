﻿using System;  // using System;
using System.Collections;  // using System.Collections;
using System.Collections.Generic;  // using System.Collections.Generic; 
using System.Linq;  // using System.Linq;
using System.Text;  // using System.Text;
using System.Threading.Tasks;  // using System.Threading.Tasks;
// Espacio entre código;
namespace E_4_3.CruzBetancourtVictorManuel  // Nombre de la práctica;
{  // Se abre la llave;
    class Grafo<T>  // Se crea la clase Grafo;
    {  // Se abre la llave;
        public Grafo() { }  // Se declara un constructor por defecto de la clase Grafo;
        public Grafo(IEnumerable<T> Vertis, IEnumerable<Tuple<T, T>> Arist)  // Se declara un constructor sobrecargado de la clase Grafo;
        {  // Se abre la llave;
            foreach (var Vert in Vertis)  // Se declara un foreach, en el cual todos los valores contenidos en la variable Vert pasan a Vertis;
                AñadVert(Vert);  // El método AñadVert ingresa cada uno de los vértices;
            // Espacio entre código;
            foreach (var Ari in Arist)  // Se declara un foreach, en el cual todos los valores contenidos en la variable Ari pasan a Arist;
                AñadAri(Ari);  // El método AñadAri ingresa cada uno de los aristas;
        }  // Se cierra la llave;
        // Espacio entre código;
        public Dictionary<T, HashSet<T>> ListAd  = new Dictionary<T, HashSet<T>>();  // Se crea una colección de la clase Dictionary, en la cual se piden dos parámetros;
        // Espacio entre código;
        public void AñadVert(T vert)  // Se declara un método público que lleva por nombre AñadVert, el cuál se encuentra sobrecargado;  
        {  // Se abre la llave;
            ListAd[vert] = new HashSet<T>();  // La colección ListAd que contiene como parámetro un vértice se iguala a un nuevo HasSet;
        }  // Se cierra la llave;
        // Espacio entre código;
        public void AñadAri(Tuple<T, T> Ari)  // Se declara un método público de nombre AñadAri, el cual se encuentra sobrecargado;
        {  // Se abre la llave;
            if (ListAd.ContainsKey(Ari.Item1) && ListAd.ContainsKey(Ari.Item2))  // Se declara un if en el cual se hace una comparación utilizando la colección ListAd;
            {  // Se abre la llave;
                ListAd[Ari.Item1].Add(Ari.Item2);  // Ari.Item2 se le agrega a la colección que lleva por nombre y parámetro ListAd[Ari.Item1];
                ListAd[Ari.Item2].Add(Ari.Item1);  // Ari.Item1 se le agrega a la colección que lleva por nombre y parámetro ListAd[Ari.Item2];
            }  // Se cierra la llave;
        }  // Se cierra la llave;
    }  // Se cierra la llave;
}  // Se cierra la llave;
