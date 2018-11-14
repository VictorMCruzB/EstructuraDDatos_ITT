using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_4_2.CruzBetancourtVictorManuel
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();//Se crea un objeto de tipo Tree llamado tree
            tree.PrintTreeA();//se llama al metodo PrintTreeA de la clase Tree
            Console.Clear();//Se limpia la consola
            tree.PrintTreeB();//se llama al metodo PrintTreeB de la clase Tree
            Console.Clear();//Se limpia la consola
            tree.PrintTreeC();//se llama al metodo PrintTreeC de la clase Tree
        }
    }
}
