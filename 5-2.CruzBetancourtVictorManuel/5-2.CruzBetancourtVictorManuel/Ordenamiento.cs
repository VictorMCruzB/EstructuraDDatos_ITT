﻿using System;  // using System;
using System.Collections.Generic;  // using System.Collections.Generic;
using System.Linq;  // using System.Linq;
using System.Text;  // using System.Text;
using System.Threading.Tasks;  // using System.Threading.Tasks;
// Espacio entre código;
namespace _5_2.CruzBetancourtVictorManuel  // Nombre de la práctica;
{  // Se abre la llave;
    class Ordenamiento  // Se crea la clase Ordenamiento;
    {  // Se abre la llave;
        double[] vector1;  // Se declara un vector de tipo double, que lleva por nombre vector1;
        double[] vector2;  // Se declara un vector de tipo double, que lleva por nombre vector2;
        double[] vector3;  // Se declara un vector de tipo double, que lleva por nombre vector3;
        double[] vector4;  // Se declara un vector de tipo double, que lleva por nombre vector4;
        public Ordenamiento()  // Se crea un constructor de la clase Ordenamiento;
        {  // Se abre la llave;
            vector1 = new double[10] { 11, 2, 3, 14, 18, 45, -3, -1, 6, 9 };  // Se le asignan 10 valores a vector1 de tipo double;
            Quicksort(vector1, 0, vector1.Length - 1);  // Se manda a llamar al método privado que lleva por nombre QuickSort y se hace uso de él para que los números de contenidos en vector1 se ordenen en forma ascendente;
            vector2 = new double[12] { 1, 3, 5, 7, 8, 3, 9, .7071, 16.5664, 12, 0, 10 };  // Se le asignan 12 valores a vector2 de tipo double;
            Quicksort(vector2, 0, vector2.Length - 1);  // Se manda a llamar al método privado que lleva por nombre QuickSort y se hace uso de él para que los números de contenidos en vector2 se ordenen en forma ascendente;
            vector3 = new double[12] { 3, 7, 15, (double)4 / 3, 155, 100, 15, Math.Sqrt(3), 5, 2, 3, 2 };  // Se le asignan 12 valores a vector3 de tipo double;
            Quicksort(vector3, 0, vector3.Length - 1);  // Se manda a llamar al método privado que lleva por nombre QuickSort y se hace uso de él para que los números de contenidos en vector3 se ordenen en forma ascendente;
            vector4 = new double[10] { 8, 19, 7, 3, 15, 23, 34, 27, 89, 101 };  // Se le asignan 10 valores a vector4 de tipo double;
            Quicksort(vector4, 0, vector4.Length - 1);  // Se manda a llamar al método privado que lleva por nombre QuickSort y se hace uso de él para que los números de contenidos en vector4 se ordenen en forma ascendente;
            Imprimir();  // Se manda a llamar al método privado Imprimir y se hace uso de él para visualizar cada una de las listas ordenadas en la consola;
        }  // Se cierra la llave;
        // Espacio entre código;
        private void Quicksort(double[] vector, int primero, int ultimo)  // Se declara un método privado que no regresa valores, el cual lleva por nombre QuickSort (que hace una clara referencia al ordenamiento que lleva ese nombre), el cual se encuentra sobrecargado con un vector de tipo double y dos variables de tipo int;
        {  // Se abre la llave;
            int i, j, central;  // Se declaran tres variables de tipo int que llevan por nombre i, j y central;
            double pivote;  // Se declara una variable de tipo double que lleva por nombre pivote;
            central = (primero + ultimo) / 2;  // Se realiza una operación sencilla para que el procedimiento del ordenamiento funcione de manera adecuada, dicha operación se le asigna a la variable central;
            // Espacio entre código;
            pivote = vector[central];  // Al vector de tipo double se le asigna el valor contenido en la variable central como su tamaño, dicho vector se le asigna a la variable de tipo double pivote;
            i = primero;  // La variable de tipo int que lleva por nombre primero pasa a llamarse i;
            j = ultimo;  // La variable de tipo int que lleva por nombre ultimo pasa a llamarse j;
            do  // Se declara un ciclo do while pra realizar el ordenamiento;
            {  // Se abre la llave;
                while (vector[i] < pivote) i++;  // Se declara un ciclo while para incrementar a la variable i, en caso de que la condición se cumpla;
                while (vector[j] > pivote) j--;  // Se declara un ciclo while para decrementar a la variable j, en caso de que la condición se cumpla;
                if (i <= j)  // Se declara un ciclo if que tiene como condición si i es menor o igual a j hacer;
                {  // Se abre la llave;
                    double temp;  // Se declara una variable de tipo double que lleva por nombre temp;
                    temp = vector[i];  // vector[i] se iguala a la variable temp;
                    vector[i] = vector[j];  // vector[j] se iguala a vector[i]
                    vector[j] = temp;  // temp se iguala a vector[j]
                    i++; // Se incrementa i;
                    j--;  // Se decrementa j;
                }  // Se cierra la llave;
            } while (i <= j);  // Lo anterior se volverá a realizar siempre y cuando i sea menor o igual a j; 
            // Espacio entre líneas;
            if (primero < j)  // Se declara un ciclo if;
            {  // Se abre la llave;
                Quicksort(vector, primero, j);  // Se hace uso del método QuickSort y sus respectivos parámetros vector, primero, j;
            }  // Se cierra la llave;
            if (i < ultimo)  // Se declara un ciclo if;
            {  // Se abre la llave;
                Quicksort(vector, i, ultimo);  // Se hace uso del método QuickSort y sus respectivos parámetros vector, i, ultimo;
            }  // Se cierra la llave;
        }  // Se cierra la llave;
        // Espacio entre código;
        private void Imprimir()  // Se declara un método privado que no regresa valores que lleva por nombre Imprimir;
        {  // Se abre la llave;
            Console.WriteLine("Elementos ingresados en la lista 1: \n11 2 3 14 18 45 -3 -1 6 9 ");  // Imprime en la mensaje indicado en la consola y se genera un salto de línea;
            Console.WriteLine("\nLista 1 ordenada en forma ascendente");  // Imprime en la mensaje indicado en la consola y se genera un salto de línea;
            for (int i = 0; i < vector1.Length; i++)  // Se declara un ciclo for que contiene una variable de tipo int que inicia en 0 y lleva por nombre i, la cual tiene que ser menor que el tamaño de vector1 para que se incremente;
            {  // Se abre la llave;
                Console.Write("{0} ", vector1[i]);  // Se imprime de manera ordenada en forma ascendente el vector1 en la consola;
            }  // Se cierra la llave;
            Console.ReadLine();// Genera una pausa en el programa;
            Console.WriteLine("----------------------------------------------------------------------");  // Imprime en la mensaje indicado en la consola y se genera un salto de línea;
            Console.WriteLine("Elementos ingresados en la lista 2: \n1 3 5 7 8 3 9 .7071 16.5664 12 0 10 ");  // Imprime en la mensaje indicado en la consola y se genera un salto de línea;
            Console.WriteLine("\nLista 2 ordenada en forma ascendente");  // Imprime en la mensaje indicado en la consola y se genera un salto de línea;
            for (int i = 0; i < vector2.Length; i++)  // Se declara un ciclo for que contiene una variable de tipo int que inicia en 0 y lleva por nombre i, la cual tiene que ser menor que el tamaño de vector2 para que se incremente;
            {  // Se abre la llave;
                Console.Write("{0} ", vector2[i]);  // Se imprime de manera ordenada en forma ascendente el vector2 en la consola;
            }  // Se cierra la llave;
            Console.ReadLine();// Genera una pausa en el programa;
            Console.WriteLine("----------------------------------------------------------------------");  // Imprime en la mensaje indicado en la consola y se genera un salto de línea;
            Console.WriteLine("Elementos ingresados en la lista 3: \n3 7 15 4/3 155 100 15 sqrt(3) 5 2 3 2 ");  // Imprime en la mensaje indicado en la consola y se genera un salto de línea;
            Console.WriteLine("\nLista 3 ordenada en forma ascendente");  // Imprime en la mensaje indicado en la consola y se genera un salto de línea;
            for (int i = 0; i < vector3.Length; i++)  // Se declara un ciclo for que contiene una variable de tipo int que inicia en 0 y lleva por nombre i, la cual tiene que ser menor que el tamaño de vector3 para que se incremente;
            {  // Se abre la llave;
                Console.Write("{0} ", vector3[i]);  // Se imprime de manera ordenada en forma ascendente el vector3 en la consola;
            }  // Se cierra la llave;
            Console.ReadLine();  // Genera una pausa en el programa;
            Console.WriteLine("----------------------------------------------------------------------");  // Imprime en la mensaje indicado en la consola y se genera un salto de línea;
            Console.WriteLine("Elementos ingresados en la lista 4: \n8 19 7 3 15 23 34 27 89 101 ");  // Imprime en la mensaje indicado en la consola y se genera un salto de línea;
            Console.WriteLine("\nLista 4 ordenada en forma ascendente");  // Imprime en la mensaje indicado en la consola y se genera un salto de línea;
            for (int i = 0; i < vector4.Length; i++)  // Se declara un ciclo for que contiene una variable de tipo int que inicia en 0 y lleva por nombre i, la cual tiene que ser menor que el tamaño de vector4 para que se incremente;
            {  // Se abre la llave;
                Console.Write("{0} ", vector4[i]);  // Se imprime de manera ordenada en forma ascendente el vector4 en la consola;
            }  // Se cierra la llave;
            Console.WriteLine("\n----------------------------------------------------------------------");  // Imprime en la mensaje indicado en la consola y se genera un salto de línea;
            Console.ReadLine();  // Fin del programa;
        }  // Se cierra la llave;
    }  // Se cierra la llave;
}  // Se cierra la llave;
