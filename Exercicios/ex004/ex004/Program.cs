using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-*-*-* PROGRAMA DE SOMA *-*-*-");
            Console.WriteLine("Favor informe 1º número");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Favor informe 2º número");
            int n2 = int.Parse(Console.ReadLine());
            int resultado = n1 + n2;
            Console.WriteLine();
            Console.WriteLine("A soma entre " + n1 + " e " + n2 + " é igual a: " + resultado);
            Console.WriteLine();
            Console.WriteLine("-*-*-* FIM DO PROGRAMA *-*-*-");
            Console.ReadLine();
        }
    }
}
