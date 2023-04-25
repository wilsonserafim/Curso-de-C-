using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoDasClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metodos m = new Metodos();
            #region Metodo Simples
            //m.Cumprimentar();
            #endregion

            #region Metodos com parametros
            //m.Somar(10, 5);
            //m.Apresentar("Wilson", 35);
            #endregion

            #region Passagem de parametros por valor e por referencia
            /*
            int valor1 = 100;
            int valor2 = 100;

            m.AumentarValor(valor1);

            m.AumentarRef(ref valor2);

            Console.WriteLine("Valor 1: " + valor1);
            Console.WriteLine("Valor 2: " + valor2);
            */
            #endregion

            #region Metodo retorno de valores
            /*
            string nomeCompleto = m.MontaNome("Wilson", "Serafim");
            int codigoChar = m.CodigoChar('w');
            double pi = m.ValorPi();

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(codigoChar);
            Console.WriteLine(pi);
            */
            #endregion

            #region Sobregarga de metodos (Overloading)
            /*
            m.Cumprimentar();
            m.Cumprimentar("Gabriel");
            m.Cumprimentar("Gabriel", 18);

            bool res1 = m.Comparar(100, 50 * 2);
            bool res2 = m.Comparar("Wilson", "wilson");
            Console.WriteLine(res1);
            Console.WriteLine(res2);
            */

            #endregion



            Console.ReadKey();
        }
    }
}
