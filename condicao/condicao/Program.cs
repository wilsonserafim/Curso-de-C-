using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace condicao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Condição simples
            /*
            int valor = 15;

            if (valor == 5)
            {
                Console.WriteLine("Condição Verdadeira");
            }
            else
            {
                Console.WriteLine("Condição retornou \"falsa\"");
            }
            Console.ReadKey();
            */
            #endregion

            #region Condição Encadeada

            /*
            int valor = 15;

            if (valor == 5)
            {
                Console.WriteLine("Condição Verdadeira");
            }
            else if (valor >= 5 && valor < 10)
            {
                Console.WriteLine("Alternativa um");
            }
            else if (valor >= 10 && valor < 20)
            {
                Console.WriteLine("Alternativa dois");
            }
            else
            {
                Console.WriteLine("Condição retornou \"falsa\"");
            }
            Console.ReadKey();
            */

            #endregion

            #region Condição Aninhada

            /*
            int numero = 10;
            
            if (numero > 5)
            {
                Console.Write(" O número é maior que 5");

                if (numero % 2 == 0)
                {
                    Console.WriteLine(" O número é Par");
                }
                else
                {
                    Console.WriteLine(" O numero é impar");
                }
            }
            
             
            Console.ReadKey();
            */

            #endregion

            #region Condição Operador ternario

            int numero = 1;
            string mensagem = "";

            /*
             * condição ? true : false; (veja o quanto podemos diminuir o codigo
               nesse caso ele testa se o conteudo de numero é maior que 5 ?(true) ai ele
               retorna a msg "Maior que 5" e caso retorne :(false) ele retorna "Menor que 5"
            */
            mensagem = numero > 5 ? "Maior que 5" : "Menor que 5";


            /*
            if (numero > 5) 
            {
                mensagem = "Maior que 5";
            }
            else 
            {
                mensagem = "Menor que 5";
            }
            */

            Console.WriteLine(mensagem);
            Console.ReadKey();

            #endregion

        }
    }
}
