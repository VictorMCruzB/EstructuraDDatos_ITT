using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_4_2.CruzBetancourtVictorManuel
{
    class Tree
    {
        int CoordX = 0, CoordY = 2;//Coordenadas para posicionar el Arbol 
        public void AgregarVinculo(Node node, string name, string[] names)//Metodo llamado AgregarVinculo, crea las relaciones en cada nodo
        {
            if (node.vinculo != null)//Si el atributo vinculo de node es diferente de null
            {
                foreach (Node item in node.vinculo)//por cada item de la clase Node en vinculo 
                {
                    AgregarVinculo(item, name, names);//Se llama al metodo AgregarVinculo
                }
            }
            else// si no
            {
                if (node.nombre == name)//si el atributo nombre de la clase Node es igual al parametro name 
                {
                    node.vinculo = new Node[names.Length];//se crea un nuevo arreglo Node que se le asigna al atributo vinculo 
                    for (int i = 0; i < names.Length; i++)//for que va desde 0 hasta el tamaño del arreglo names - 1 
                    {
                        node.vinculo[i] = new Node(names[i]);//se crea un nuevo arreglo de Node con parametro names en i, y se iguala al atributo vinculo en la posicion i 
                    }
                }
            }
        }
        int Height = 0, Level = 0;// se crean las variables height y level del arbol 
        public void Print(Node node)//Creacion del metodo de impresion al que se le manda un parametro de tipo Node
        {

            if (node.vinculo != null)// si el atributo vinculo de node es diferente a null
            {
                Console.SetCursorPosition(CoordX, CoordY);//se usa SetCursorPosition con parametros CoordX y CoordY para que se escriba en cierta parte de la consola 
                Console.Write(node.nombre);//Se imprime el atributo nombre 
                CoordX += 5;// se le suma a la coordenada x 5 
                CoordY++;//incremento de la coordenada y
                for (int i = 0; i < node.vinculo.Length; i++)// for desde 0 hasta el tamaño del arreglo vinculo 
                {
                    Print(node.vinculo[i]);//se llama el metodo impresion con parametro vinculo en la posicion i 
                }
                CoordX += 5;// se le suma a la coordenada x 5 
            }
            else// si no 
            {
                Console.SetCursorPosition(CoordX, CoordY);// el cursor se posiciona en las coordenadas 
                Console.Write(node.nombre);// se imprime el atributo nombre 
                CoordY++;// se incrementa la coordenada y 
            }

            Height = ((CoordY - 1) / 2) - 1;// altura se iguala a ((CoordY - 1) /2) - 1
            Level = Height;// level se iguala a height 
        }
        public void HeightLevel()//Metodo que imprime Height y Level 
        {
            Console.WriteLine("\n\nAltura: {0}", Height);//se imprime en consola Height
            Console.WriteLine("Nivel: {0}", Level);//se imprime en consola Level
            //No pude hacer que se imprimiera la ruta al camino mas largo automaticamente 
            //Imprme la ruta al elemento mas largo 
        }

        public void PrintTreeA()//Metodo que imprime el arbol A 
        {
            Console.WriteLine("Tree A");//Escribe lo que esta entre comillas
            Node RootNode = new Node("E");//se crea un objeto de tipo Node dandole de parametro la letra E que es la raiz 
            Tree Arbol = new Tree();//se crea un objeto de tipo Tree llamado Arbol
            Arbol.AgregarVinculo(RootNode, "E", new string[] { "F", "A" });//se llama el metodo AgregarVinculo dandole distintos parametros
            Arbol.AgregarVinculo(RootNode, "A", new string[] { "B", "C", "D" });//se llama el metodo AgregarVinculo dandole distintos parametros
            Arbol.Print(RootNode);//Se llama el metodo que imprimira al arbol llamado Impresion 
            Arbol.HeightLevel();//Se llama al metodo HeightLevel que imprime la altura y el nivel 
            Console.WriteLine("Ruta al elemento mas largo: E-->A-->(B,C,D)"); //Imprme la ruta al elemento mas largo

            Console.ReadKey();
        }

        public void PrintTreeB()
        {
            Console.WriteLine("Tree B");//Escribe lo que esta entre comillas
            Node RootNode = new Node("C");//se crea un objeto de tipo Node dandole de parametro la letra C que es la raiz
            Tree Arbol = new Tree();//se crea un objeto de tipo Tree llamado Arbol
            Arbol.AgregarVinculo(RootNode, "C", new string[] { "D", "F", "G", "A" });//se llama el metodo AgregarVinculo dandole distintos parametros
            Arbol.AgregarVinculo(RootNode, "A", new string[] { "B" });//se llama el metodo AgregarVinculo dandole distintos parametros
            Arbol.AgregarVinculo(RootNode, "B", new string[] { "E" });//se llama el metodo AgregarVinculo dandole distintos parametros
            Arbol.Print(RootNode);//Se llama el metodo que imprimira al arbol llamado Impresion 
            Arbol.HeightLevel();//Se llama al metodo HeightLevel que imprime la altura y el nivel 
            Console.WriteLine("Ruta al elemento mas largo: C-->A-->B-->E");//Imprme la ruta al elemento mas largo

            Console.ReadKey();
        }

        public void PrintTreeC()
        {
            Console.WriteLine("Tree C");//Escribe lo que esta entre comillas
            Node NodoRaiz = new Node("K");//se crea un objeto de tipo Node dandole de parametro la letra K que es la raiz
            Tree Arbolito = new Tree();//se crea un objeto de tipo Tree llamado Arbol
            Arbolito.AgregarVinculo(NodoRaiz, "K", new string[] { "A", "C", "B", "D" });//se llama el metodo AgregarVinculo dandole distintos parametros
            Arbolito.AgregarVinculo(NodoRaiz, "D", new string[] { "I    J", "E" });//se llama el metodo AgregarVinculo dandole distintos parametros //No pude hacer que I tuviera al hijo J 
            Arbolito.AgregarVinculo(NodoRaiz, "E", new string[] { "F", "G" });//se llama el metodo AgregarVinculo dandole distintos parametros
            Arbolito.AgregarVinculo(NodoRaiz, "G", new string[] { "H" });//se llama el metodo AgregarVinculo dandole distintos parametros
            Arbolito.Print(NodoRaiz);//Se llama el metodo que imprimira al arbol llamado Impresion 
            Arbolito.HeightLevel();//Se llama al metodo HeightLevel que imprime la altura y el nivel 
            Console.WriteLine("Ruta al elemento mas largo: K-->D-->E-->G-->H");//Imprme la ruta al elemento mas largo 

            Console.ReadKey();
        }
    }
}
