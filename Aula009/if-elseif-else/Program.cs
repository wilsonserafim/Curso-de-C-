using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_elseif_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;

            Console.Write("Digite o Primeiro número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o Segundo número: ");
            n2 = int.Parse(Console.ReadLine());

            bool n1Maiorn2 = n1 > n2;
            bool n1Menorn2 = n1 < n2;
            bool n1Igualn2 = n1 == n2;

            if (n1Maiorn2)
            {
                Console.WriteLine(" O Primeiro numero é MAIOR que o Segundo");
            }
            else if (n1Menorn2)
            {
                Console.WriteLine(" O Primeiro número é IGUAL ao Segundo ");
            }
            else 
            {
                Console.WriteLine(" O Primeiro numero e MENOR que o Segundo");
            }

            Console.ReadLine();
        }
    }
}
