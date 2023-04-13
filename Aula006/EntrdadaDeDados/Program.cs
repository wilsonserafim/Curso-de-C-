using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntrdadaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nome = "";

            Console.WriteLine("Programa que efetua a leitura de dados");
            Console.WriteLine("Ola. Qual é o seu nome?");
            Console.Write("Digite seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("{0}, Seja bem vindo as aulas de programação", nome); // esse {0} indica que na quele local o sistema vai por a variavel que esta após
                                                                                // a virgula e esse 0 indica o indice.
            Console.ReadLine();
        }
    }
}
