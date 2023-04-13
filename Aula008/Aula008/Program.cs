using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-* PROGRAMA DE PAGAMENTOS -*-*-*-*-*-*-*-*-*");
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine(" :-*-*-*-*-*-*-*-*:Dados informados:-*-*-*-*-*-*-*-*:");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.ReadLine();
            */

            string nome;
            string sobrenome;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite seu sobrenome: ");
            sobrenome = Console.ReadLine();

            string nomeCompleto = string.Concat(nome, " ", sobrenome);

            Console.WriteLine(nomeCompleto);
            Console.ReadLine();


        }
    }
}
