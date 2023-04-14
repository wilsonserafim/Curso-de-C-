using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu nome?");
            String nome = Console.ReadLine();
            Console.WriteLine("Olá " + nome + ", é um prazer em te conhecer!");
            Console.ReadLine();
        }
    }
}
