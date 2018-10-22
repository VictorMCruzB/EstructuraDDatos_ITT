using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3._3.CruzBetancourtVictorManuel
{
    class Carta  // Clase Carta;
    {
        private int numero;  // Se declara la variable privada numero de tipo int;
        private Figura figura;  // Se declara la variable privada figura de tipo Figura;
        private string representacion;  // Se declara la variable representacion número de tipo string;
        private int valor;  // Se declara la variable privada valor de tipo int;

        //gets y sets
        public int Numero
        {
            get
            {
                return numero;
            }
            set
            {
                numero = value;
            }
        }
        public Figura Fig
        {
            get
            {
                return figura;
            }
            set
            {
                figura = value;
            }
        }
        public string Representacion
        {
            get
            {
                return representacion;
            }
            set
            {
                representacion = value;
            }
        }
        public int Valor
        {
            get
            {
                return valor;
            }
            set
            {
                valor = value;
            }
        }

        public Carta() { }  // Se crea un constructor por defecto;
        // constructor;
        public Carta(int n, int figura, string represent, int valor)  // Constructor Sobrecargado;
        {
            numero = n;  // La variable numero toma el valor de n;
            this.figura = (Figura)figura;  // La variable figura toma su mismo valor;
            representacion = represent;  // La variable representacion toma el valor de represent;
            this.valor = valor;  // La variable valor toma su mismo valor;
        }

        public enum Figura  // Enumeración de las figuras;
        {
            Diamante = 1, Trebol = 2, Corazon = 3, Pique = 4,
        }
        public void Inicio() // Introducción al juego;
        {
            Console.WriteLine("Tienes lo necesario para aprobar la materia de Estructura de datos, entonces este juego es para ti ;)");  // Envía un mensaje a la consola y genera un salto de línea;
            Console.WriteLine();  // Se genera un salto de línea;
            Console.Write("Introduce tu nombre de usuario: ");  // Envía un mensaje a la consola;
            string Jugador = Console.ReadLine(); // Lee lo escrito por el usuario y lo guarda en la variable indicada; 
            Console.Clear(); // Borra la consola; 
            Console.WriteLine("Comencemos {0}", Jugador);  // Envía un mensaje a la consola y genera un saltode línea;
            Console.WriteLine("Presione cualquier tecla para continuar...");  // Envía un mensaje a la consola y genera un saltode línea;
            Console.ReadKey();  // Finaliza el código en cuestión;
            Console.WriteLine();  // Se genera un salto de línea;
        }
        public void RellenarCartas(ArrayList Numero, ArrayList Figuras) //Rellena de cartas los ArrayList;
        {
            for (int i = 0; i < 4; i++) // Un for para agregar las letras A,K,Q,J 4 veces cada una;
            {
                Numero.Add("A");  // Se agrega el valor "A" a la lista Numero;
                Numero.Add("K");  // Se agrega el valor "K" a la lista Numero;
                Numero.Add("Q");  // Se agrega el valor "Q" a la lista Numero;
                Numero.Add("J");  // Se agrega el valor "J" a la lista Numero;
                for (int j = 2; j < 11; j++)  // Se declara un ciclo for; 
                {
                    Numero.Add(j); // Agrega los numeros del 2 al 10 4 veces cada uno;
                }
            }
            for (int i = 0; i < 4; i++) // Un ciclo for para agregar las figuras 13 veces cada una;
            {
                string Figura = "";
                if (i == 0) // Si el valor de i es igual a 0;
                {
                    Figura = "♠"; // Figura va a ser igual a la figura Picas;
                }
                if (i == 1) // Si el valor de i es igual a 1;
                {
                    Figura = "♣"; // Figura va a ser igual a la figura Trebol;
                }
                if (i == 2) // Si el valor de i es igual a 2;
                {
                    Figura = "♦"; // Figura va a ser igual a la figura Diamante;
                }
                if (i == 3) // Si el valor de i es igual a 3;
                {
                    Figura = "♥"; // Figura va a ser igual a la figura Corazon;
                }
                for (int p = 0; p < 13; p++) // Agrega cada figura correspondiente 13 veces;
                {
                    Figuras.Add(Figura); //Agregara el valor de Figura a la lista Figuras;
                }
            }
        }

        public void Barajar(ArrayList Numero, ArrayList Figuras, Stack Mazo, Stack MazoNumeros, Random Aleatorio) //Pasa un dato aleatorio de la lista; 
        {                                                                                               // A la pila ordenados aleatoriamente y los va eliminando de la lista hasta que no quede ninguno;
            for (int i = 0; i < 52; i++) 
            {
                int Variable = Aleatorio.Next(0, Numero.Count);  // Se declara una variable de nombre Variable;
                Mazo.Push(Figuras[Variable]); // Push agrega elementos a la pila, en este caso un simbolo de la lista con posicion aleatoria;
                MazoNumeros.Push(Numero[Variable]); // Push agrega elementos a la pila, en este caso un nuemro de la lista con posicion aleatoria;
                Numero.RemoveAt(Variable); //Elimina el numero de la lista (El agregado a la pila);
                Figuras.RemoveAt(Variable); // Elimina  el simbolo de la lista (Agregado a la pila);
            }
        }

        public void Repartir_Cartas(Stack Mazo, Stack MazoNumeros, Stack Jugador, Stack Ganados, Stack Perdidos) // Reparte Cartas y las va sumando; 
        {
            object Carta1 = MazoNumeros.Pop();  //Guarda el valor del primer elemento en la pila y lo saca con el Pop;
            object Carta2 = MazoNumeros.Pop();  //Guarda el valor del segundo elemento en la pila y lo saca con el Pop;
            Console.WriteLine("Aqui tienes tus dos cartas: \n");  // Se envía un mensaje a al consola y genera un salto de línea;
            Console.Write (Mazo.Pop() + "" + Carta1); // Te imprime tus primeras cartas de manera aleatoria;
            Console.WriteLine("    " + Mazo.Pop() + "" + Carta2);  // Se envía un mensaje a la consola y genera un salto de línea;
            Jugador.Push(Carta1); // La carta que te dio la mete a una pila donde las ira sumando;
            Jugador.Push(Carta2);  // La carta que te dio las metera a una pila para poderlas sumar;

            int Resultado = 0; // Inicia suma de cartas;
            List<int> Suma = new List<int>(); // Se crea una listade nombre Suma;
            for (int i = 0; i < 2; i++) // Hace dos veces esa actividad;
            {
                var Número = Jugador.Peek(); // Agrego una variable de tipo var con el valor del primer elemento de la pila pero no lo saca de la pila;
                if (Número.ToString() == "K"|| Número.ToString()=="Q" || Número.ToString() =="J") // Si valor de Número es igual a K, Q o J. Número valdra 10;
               {
                    Número = 10;                  // Se le da el valor de 10 a Número;
               }
                if(Número.ToString() == "A") // Si Número es igual a un A se le preguntara a numerito si quiere que su carta valga 1 u 11;
                {
                    As:  // Etiqueta As;
                    Console.WriteLine("Desea que el A´s valga 1 u 11 (Introduzca solo el numero): ");  // Se envía un mensaje a la consola y se genera un salto de línea;
                    int Valor = int.Parse(Console.ReadLine());  // Se lee lo que ingresa el usuario y se guarda en la varuable indicada;
                    if (Valor== 1) // Si responde 1; 
                    {
                        Número = 1; // Número vale 1;
                    }
                    else if (Valor == 11) // Si responde 11;
                    {
                        Número = 11; // Número vale 11;
                    }
                    else // Si no es ninguna de esas dos;
                    {
                        Console.WriteLine("Introduzca un numero valido"); // Debe introducir un numero válido:
                        goto As; // Te regresa a la etiqueta As;
                    }
                }
                Suma.Add(Convert.ToInt32(Número)); // Se agrega Número a una lista que se sumara mas adelante;
                Jugador.Pop(); // Saca la carta de jugador;
            }

            foreach (var item in Suma) // Por cada elemento de cualquier tipo en Suma; 
            {
                Resultado = item + Resultado; // se sumara y se agregara el valor a Resultado;
            }
            Console.WriteLine("El resultado de sus cartas es de: " + Resultado); // Se en vía el mensaje 'El resultado de tus cartas es de n' a la consola y se genera un salto de línea;
        Regresar:  // Etiqueta Regresar;
            if(Resultado<21) // Si el resultado es menor a 21;
            {
                Console.WriteLine("Presione cualquier tecla para entregar la siguiente carta..."); // Se te entrega otra carta si no igual pierdes y se genera un salto de línea;
                Console.ReadKey();  // Detiene momentáneamente el programa hasta que el usuario pulse una nueva tecla;
                var CartaMan = MazoNumeros.Pop(); // Guarda la carta en una variable var; 
                Console.WriteLine(Mazo.Pop() + ""+ CartaMan); // Escribe tu carta con la ayuda de las de ambas pilas;
                // Declarando para usar en el ciclo;
                Jugador.Push(CartaMan); // Con la ayuda del Push saca la carta del arreglo;
                var número = Jugador.Peek(); // Agrega una carta de la pial de numeros a la variable número;
                if (número.ToString() == "K" || número.ToString() == "Q" || número.ToString() == "J") // Si valor de número es igual a K, Q o J. número valdra 10;
                {
                    número = 10; // número guarda el valor de 10;
                }
                if (número.ToString() == "A") // Si número es igual a A;
                {
                As:  // Etiqueta As;
                    Console.WriteLine("Desea que el A´s valga 1 u 11 (Introduzca solo el numero): "); // Se pregunta el valor del As y se genera un salto de línea;
                    int Valor = int.Parse(Console.ReadLine());
                    if (Valor == 1) // Si selecciona el 1;
                    {
                        número = 1; // número es igual a 1;
                    }
                    else if (Valor == 11)// Si selecciona el 11;
                    {
                        número = 11; // número es igual a 11;
                    }
                    else // Si selecciona un valor diferente;
                    {
                        Console.WriteLine("Introdujo un numero inválido"); // Se genera el mensaje 'Introdujo un valor inválido' y genera un salto de línea;
                        goto As;// Regresa a la etiqueta As;
                    }
                }
                Suma.Add(Convert.ToInt32(número));// Agrega número a la lista Suma;
                Resultado = Resultado + Suma.Last();  // La variable Resultado recibe un nuevo valor;
                Console.WriteLine("El resultado de sus cartas es de: {0}",Resultado);  // Imprime el resutado de la suma y se genera un salto de línea;           
                goto Regresar; // Regresa a la etiqueta Regresar;
            }
            if(Resultado==21) // Si resultado es igual a 21 ganas;
            {
                Console.WriteLine("\n¡Felicidades haz ganado el juego!");  // Se envía un mensaje a la consola y se genera un salto de línea;
                Console.WriteLine("Presione cualquier tecla para el siguiente juego"); // Se envía un mensaje a la consola y se genera un salto de línea;
                Console.ReadKey();  // Se detiene momentáneamente el programa, hasta que el usuario presione cualquier tecla;
                Ganados.Push(1);  // Se agrega el elemento uno a la pila;
            }

            if (Resultado> 21) // Si resultado es mayor a 21 pierdes;
            {
                Console.WriteLine("\nPerdiste el juego");  // Se envía un mensaje a la consola y se genera un salto de línea; 
                Console.WriteLine("Presione cualquier tecla para el siguiente juego");  // Se envía un mensaje a la consola y se genera un salto de línea;
                Console.ReadKey();  // Se detiene momentáneamente el programa, hasta que el usuario presione cualquier tecla;
                Perdidos.Push(2);  // Se agrega el elemento dos a la pila;
            }

        }
            public void Ganados_Perdidos(Stack Ganados, Stack Perdidos, int Iniciar)  // Visualiza los juegos ganados y perdidos por el usuario;
        {
            Console.Clear(); // Borra la pantalla;
            Console.WriteLine("Usted gano {0} juegos de {1} jugados", Ganados.Count, Iniciar); // Manda el mensaje 'Usted gano n(el numero de elementos en la pila)' y se genera un salto de línea;
            Console.WriteLine("Usted perdio {0} juegos de {1} jugados", Perdidos.Count, Iniciar); // Manda el mensaje 'De n juegos jugados' y se genera un salto de línea;
        }
        public void Menú()  // Creación del método Menú();
        {
            Carta Baraja = new Carta(); // Se crea el objeto de tipo Carta;
            int iniciar = 0;// Creo la variable para despues usarlo al ver cuantas veces se jugara;
            Stack Ganados = new Stack(); // Se crea la pila de juegos ganados;
            Stack Perdidos = new Stack(); // Se crea la pila de juegos perdidos;
            Baraja.Inicio(); // Se manda llamar el metodo Bienvenida;
            Console.Clear();   // Borra lo de la consola para un nuevo juego;
        Jugar:  // Etiqueta Jugar;
            Console.Clear();
            Stack Jugador = new Stack(); // Se crea la pila de jugador; 
            List<int> Números = new List<int>(); // Se crea la lista Números;
            Stack Mazo = new Stack(); // Se crea la pila de mazo;
            Stack MazoNumeros = new Stack(); // Se crea la pila mazo de numeros;
            ArrayList Numero = new ArrayList(); // Se crea un ArrayList de numeros;
            ArrayList Figuras = new ArrayList(); // Se crea un ArrayList de Figuras;
            Random Aleatorio = new Random(); // Se crea una variable Random;           
            Baraja.RellenarCartas(Numero, Figuras);  // Llena de cartas las listas Numero y Figuras;        
            Baraja.Barajar(Numero, Figuras, Mazo, MazoNumeros, Aleatorio); // Barajea las cartas de la lista metiendolas una pila nueva;
            Baraja.Repartir_Cartas(Mazo, MazoNumeros, Jugador, Ganados, Perdidos); // Entrega las cartas y las va eliminando de la pila asi como va entregando el resultado;
        VolverAJugar:  // Etiqueta VolverAJugar;
            Console.WriteLine("¿Desea Volver a jugar? Si/No"); // Se manda un mensaje a la consola y se genera un salto de línea;
            string v = Console.ReadLine().ToUpper();  // Se lee lo que ingrese el usuario y se guarda en la variable indicada;
            if (v == "SI")  // Si v == "SI";
            {
                iniciar = iniciar + 1;  // La variable iniciar toma un nuevo valor;
                goto Jugar;  // Se regresa a la etiqueta Jugar;
            }
            else if (v == "NO")  // Si v == "NO"
            {
                iniciar = iniciar + 1;  // La variable iniciar toma un nuevo valor;
                Baraja.Ganados_Perdidos(Ganados, Perdidos, iniciar); //Al final de los 5 juegos imprime cuantos ganaste y cuantos perdiste;
                Console.ReadKey();  // Se detiene momentáneamente el programa, hasta que el usuario presione una tecla;
            }
            else  // Si no;
            {
                Console.Write("Introduzca un valor correcto; Si o No solamente.");  // Se manda un mensaje a la consola;
                goto VolverAJugar;  // Se regresa a la etiqueta VolverAJugar;
            }
        }
    }
}
