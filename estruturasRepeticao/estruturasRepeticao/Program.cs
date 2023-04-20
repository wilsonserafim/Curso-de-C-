using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estruturasRepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Ciclo While

            /*
            int valor = 0;
            
            while (valor <= 10) 
            {
                Console.WriteLine("O valor é " + valor);
                valor++;
            }

            Console.ReadKey();
            */

            #endregion

            #region Ciclo do While

            /*
            int valor = 0;

            do
            {
                Console.WriteLine("O valor é " + valor);
                valor++;
            }
            while (valor >= 10);

            Console.ReadKey();
            */

            #endregion

            #region Ciclo For

            /*
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("O valor é " + i);
            }

            Console.ReadKey();
            */

            #endregion

            #region Ciclo Foreach

            /*
            string[] nomes = { "Wilson", "Andréa", "Giovanna", "Rosinete", "Elaine" };
            
            foreach (string nome in nomes) 
            {
                Console.WriteLine(" Nome: " + nome);
            }
            Console.ReadKey();
            */

            #endregion

            #region Sequencia Fibonacci

            
            int a = 0; int b = 1; int c = 0;

            Console.Write("Quantos valores: ");
            int valores  = int.Parse(Console.ReadLine());

            Console.WriteLine("Sequencia de Fibonacci com " + valores + " valores");

            for (int i = 0; i < valores; i++)
            {
                if (i < valores - 1) 
                {
                    Console.Write(a + ",");
                }
                else
                {
                    Console.Write(a);
                }
                

                c = a + b;
                a = b;
                b = c;
            }

            Console.ReadKey();
            

            #endregion
        }
    }
}
