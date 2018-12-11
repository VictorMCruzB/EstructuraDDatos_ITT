﻿using System;  // using System;
using System.Collections;  // using System.Collections;
using System.Collections.Generic;  // using System.Collections.Generic;
using System.Linq;  // using System.Linq;
using System.Text;  // using System.Text;
using System.Threading.Tasks;  // using System.Threading.Tasks;
// Espacio entre líneas;
namespace _6_3.CruzBetancourtVictorManuel  // Nombre de la práctica;
{  // Se abre la llave;
    class Búsqueda  // Se crea la clase Búsqueda;
    {  // Se abre la llave;
        public void Ejemplo1()  // Se declara un método público que no regresa valores que lleva por nombre Ejemplo1();
        {  // Se abre la llave;
            Hashtable TablaHash = new Hashtable();  // Se crea una tabla por medio de la instancia Hashtable que lleva por nombre TablaHash;
            // Espacio entre código;
            TablaHash.Add(5, "Victor");  // Se agrega el elemento (5, "Victor") a la tabla que lleva por nombre TablaHash;
            TablaHash.Add(21, "Manuel");  // Se agrega el elemento (21, "Manuel") a la tabla que lleva por nombre TablaHash;
            TablaHash.Add(53, "Cruz");  // Se agrega el elemento (53, "Cruz") a la tabla que lleva por nombre TablaHash;
            TablaHash.Add(35, "Betancourt");  // Se agrega el elemento (35, "Betancourt") a la tabla que lleva por nombre TablaHash;
            TablaHash.Add(1899, "100");  // Se agrega el elemento (1899, "100") a la tabla que lleva por nombre TablaHash;
            // Espacio entre código;
            Console.WriteLine("Ejemplo 1\n\nTabla Hash\n");  // Se imprime el mensaje indicado en la consola y se genera un salto de línea;
            foreach (DictionaryEntry elemento in TablaHash)  // Se crea un ciclo foreach para mostrar los elementos contenidos en TablaHash, para eso es necesario que hagamos uso de la instancia DictionaryEntry, ya que esta instancia tiene la dupla llave, valor y es justamente lo que necesitamos para la poder mostrar la TablaHash;
            {  // Se abre la llave;
                Console.WriteLine("({0}, {1})", elemento.Key, elemento.Value);  // Se imprime el mensaje indicado en la consola y se genera un salto de línea;
            }  // Se cierra la llave;
            // Espacio entre código;
            Console.WriteLine("====================================================");  // Se imprime el mensaje indicado en la consola y se genera un salto de línea;
            // Espacio entre código;
            Console.WriteLine("Número de elementos contenidos en la tabla: {0}", TablaHash.Count);  // Se imprime el mensaje indicado en la consola y se genera un salto de línea;
            // Espacio entre código;
            Console.WriteLine("====================================================");  // Se imprime el mensaje indicado en la consola y se genera un salto de línea;
            // Espacio entre código;
            Console.WriteLine("Elemento que se encuentra en la llave 567: {0}", TablaHash[35]);  // Se imprime el mensaje indicado en la consola y se genera un salto de línea;
            Console.WriteLine("Elemento que se encuentra en la llave 445: {0}", TablaHash[40]);  // Se imprime el mensaje indicado en la consola y se genera un salto de línea;
            // Espacio entre código;
            Console.WriteLine("====================================================");  // Se imprime el mensaje indicado en la consola y se genera un salto de línea;
            // Espacio entre código;
            Console.ReadKey();  // Se genera un salto de línea;
        }  // Se cierra la llave;
        // Espacio entre código;
        public void Ejemplo2()  // Se declara un método público que no regresa valores que lleva por nombre Ejemplo2();
        {  // Se abre la llave;
            Hashtable TablaHash = new Hashtable();  // Se crea una tabla por medio de la instancia Hashtable que lleva por nombre TablaHash;
            // Espacio entre código;
            TablaHash.Add(120, 324);  // Se agrega el elemento (120, 324) a la tabla que lleva por nombre TablaHash;
            TablaHash.Add(325, 945);  // Se agrega el elemento (325, 945) a la tabla que lleva por nombre TablaHash;
            TablaHash.Add(401, 120);  // Se agrega el elemento (401, 120) a la tabla que lleva por nombre TablaHash;
            TablaHash.Add(500, 1000);  // Se agrega el elemento (500, 1000) a la tabla que lleva por nombre TablaHash;
            TablaHash.Add(975, 1);  // Se agrega el elemento (975, 1) a la tabla que lleva por nombre TablaHash;
            // Espacio entre código;
            Console.WriteLine("Ejemplo 2\n\nTabla Hash\n");  // Se imprime el mensaje indicado en la consola y se genera un salto de línea;
            foreach (DictionaryEntry elemento in TablaHash)  // Se crea un ciclo foreach para mostrar los elementos contenidos en TablaHash, para eso es necesario que hagamos uso de la instancia DictionaryEntry, ya que esta instancia tiene la dupla llave, valor y es justamente lo que necesitamos para la poder mostrar la TablaHash;
            {  // Se abre la llave;
                Console.WriteLine("({0}, {1})", elemento.Key, elemento.Value);  // Se imprime el mensaje indicado en la consola y se genera un salto de línea;
            }  // Se cierra la llave;
            // Espacio entre código;
            Console.WriteLine("====================================================");  // Se imprime el mensaje indicado en la consola y se genera un salto de línea;
            // Espacio entre código;
            Console.WriteLine("Número de elementos contenidos en la tabla: {0}", TablaHash.Count);  // Se imprime el mensaje indicado en la consola y se genera un salto de línea;
            // Espacio entre código;
            Console.WriteLine("====================================================");  // Se imprime el mensaje indicado en la consola y se genera un salto de línea;
            // Espacio entre código;
            Console.WriteLine("Elemento que se encuentra en la llave 567: {0}", TablaHash[401]);  // Se imprime el mensaje indicado en la consola y se genera un salto de línea;
            Console.WriteLine("Elemento que se encuentra en la llave 445: {0}", TablaHash[120]);  // Se imprime el mensaje indicado en la consola y se genera un salto de línea;
            // Espacio entre código;
            Console.WriteLine("====================================================");  // Se imprime el mensaje indicado en la consola y se genera un salto de línea;
            // Espacio entre código;
            Console.ReadKey();  // Se genera un salto de línea;
        }  // Se cierra la llave;
    }  // Se cierra la llave;
}  // Se cierra la llave;
