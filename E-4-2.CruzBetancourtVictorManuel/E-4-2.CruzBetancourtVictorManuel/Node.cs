using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_4_2.CruzBetancourtVictorManuel
{
    class Node
    {
        public string nombre;//Variable de tipo string 
        public Node[] vinculo;//Arreglo de tipo Node llamado vinculo
        public Node() { }//Constructor 
        public Node(string name)//Construcutor sobrecargado
        {
            nombre = name;//Se iguala la variable nombre al parametro name
        }
    }
}
