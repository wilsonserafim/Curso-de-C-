using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-*-*-* PROGRAMA DESCONTO EM PRODUTO *-*-*-");
            Console.WriteLine("Favor informe o nome do produto");
            string nomeProduto = Console.ReadLine();
            Console.WriteLine("Favor informe o valor do Produto");
            float valor = float.Parse(Console.ReadLine());
            Console.WriteLine("Favor informe o valor do desconto sem o simbolo de percentual %");
            float percentual = float.Parse(Console.ReadLine());
            float desconto = (percentual / 100) * valor;
            float novoValor = valor - desconto; 
            Console.WriteLine();
            Console.WriteLine(" O valor do produto: " + nomeProduto + " com desconto de: " + percentual + "% fica com o novo valor de : R$" + novoValor);
            Console.WriteLine();
            Console.WriteLine("-*-*-* FIM DO PROGRAMA *-*-*-");
            Console.ReadLine();
        }
    }
}
