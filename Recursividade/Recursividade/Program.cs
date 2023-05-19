using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Recursivo r = new Recursivo();
            
            r.ExecultarRecursivo(" Olá Mundo!!! \n ", 5);

            Console.ReadLine();
        }
    }
}
