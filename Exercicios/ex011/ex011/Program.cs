using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            11) Desenvolva uma lógica que leia os valores de A, B e C de uma equação do
            segundo grau e mostre o valor de Delta.
            */
            Console.WriteLine("-*-*-* PROGRAMA EQUAÇÃO DE 2 GRAU - VALOR DE DELTA *-*-*-");
            Console.WriteLine();
            Console.WriteLine("    Sabendo que a equação de 2 grau para saber o valor de delta é: ");
            Console.WriteLine();
            Console.WriteLine("           Delta = X²-4*A*B              ");
            Console.WriteLine();
            Console.WriteLine("Favor informe o valor de A");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Favor informe o valor de B");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Favor informe o valor de C");
            float c = float.Parse(Console.ReadLine());
            float delta = (b * b) - (4 * a * c);
            Console.WriteLine();
            Console.WriteLine("O Valor de Delta é: " + delta);
            Console.WriteLine();
            Console.WriteLine("-*-*-* FIM DO PROGRAMA *-*-*-");
            Console.ReadLine();
        }
    }
}
