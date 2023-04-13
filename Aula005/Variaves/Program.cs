using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string texto;

            texto = "Variaveis";
            Console.WriteLine(texto);

            texto = "Wilson Silva";
            Console.WriteLine(texto);
            */
            int n1 = 2;
            int n2 = 4;

            Console.WriteLine(n1 + " > " + n2 + " = " + (n1 > n2));
            Console.WriteLine(n1 + " < " + n2 + " = " + (n1 < n2));
            Console.WriteLine(n1 + " != " + n2 + " = " + (n1 != n2));
            Console.WriteLine(n1 + " == " + n2 + " = " + (n1 == n2));

            Console.ReadKey();
        }
    }
}
