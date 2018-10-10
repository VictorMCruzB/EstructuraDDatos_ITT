using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_1.CruzBetancourtVictorManuel
{
    class Carrera  // Clase Carrera;
    {
        public void Captura(int Cantidad)  // Se declara un método llamado Captura, el cual recibe un parámetro de tipo int llamado Cantidad;
        {
            ArrayList Materia = new ArrayList();  // Se declara un ombjeto de nombre Materia;
            ArrayList Calificación = new ArrayList();  // Se declara un objeto de nombre Calificación;  
            for (int i = 0; i < Cantidad; i++)  // Se inicializa un ciclo for de 0 y todos los valores que sean menores al valor contenido en la variable Cantidad;
            {
                Console.WriteLine("Ingrese el nombre de la materia {0}", i + 1);  // Se pide que se ingrese el nombre de la materia;
                Materia.Add(Console.ReadLine());  // Se lee el valor ingresado por el usuario y se le asigna a Materia;
                for (int j = 0; j < Cantidad; j++)  // Se inicializa un ciclo for de 0 y todos los valores que sean menores al valor contenido en la variable Cantidad;
                {
                    Console.WriteLine("Ingrese la calificación del alumno {0}", j + 1);  // Se le pide al usuario que ingrese la calificación del alumno;
                    Calificación.Add(Console.ReadLine());  // Se lee el valor ingresado por el usuario y se le asigna a Calificación; 
                }
            }
            Console.WriteLine();  // Se genera un salto de línea;
            foreach (var item in Materia)  // Se inicializa un ciclo foreack, en el cual los valores contenidos en Materia se le asignan a la variable item;
            {
                Console.WriteLine(item+"    ");  // Se muestran los datos de la variable item y genera un salto de línea;
                foreach (var item2 in Calificación)  // Se inicializa un ciclo foreach, en el cual los valores contenidos en Calificación se le asignan a la variable item 2;
                {
                    Console.Write(item2+"   ");  // Se muestran los datos de la variable item2;
                }
                Console.WriteLine();  // Se genera un salto de línea;
            }
        }
    }
}
