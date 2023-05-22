using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryeCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, res;
            res=n1=n2=0;

            n1 = 10;
            n2 = 0;

            try
            {
                res = n1 / n2;
                Console.WriteLine("{0}/{1}={2}", n1,n2,res);
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
                Console.WriteLine("Ex: " + e);
                Console.WriteLine("Tipo: " + e.GetType());
            }
            

            

            Console.ReadLine();
        }
    }
}
