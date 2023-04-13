using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[6] { "Elaine", "Andréa", "Wilson", "João", "Rosinete", "Giovanna" };

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine(nomes[i]);
            }
            Console.ReadLine();
        }
    }
}
