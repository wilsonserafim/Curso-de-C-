using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Operadores Matematicos

            /*
            int num1 = 10;
            int num2 = 2;

            Console.WriteLine();
            Console.WriteLine(num1 + num2);
            Console.WriteLine();
            Console.WriteLine(num1 - num2);
            Console.WriteLine();
            Console.WriteLine(num1 * num2);
            Console.WriteLine();
            Console.WriteLine(num1 / num2);
            Console.WriteLine();
            Console.WriteLine(num1 % num2);
            Console.WriteLine();

            Console.ReadLine();

            */
            #endregion

            #region Precedencia de Operadores

            /*
            
            double num1 = 100;
            double num2 = 10;
            double num3 = 5;

            double result = (num1 + num2) * (num3 / 3);
            Console.ReadLine();
            
            /*
            o sistema sempre vai resolver o que tiver entre parenteses igual na nossa matemática tradicional  

            Precedência na matemática, da maior pra menor:

            Parênteses;

            Expoentes;

            Multiplicações e divisões; (da esquerda para a direita);

            Somas e subtrações. (da esquerda para a direita);

            */

            #endregion

            #region Incrmento e decremento

            /*
            int num1 = 10;
            Console.WriteLine(num1);
            Console.WriteLine();
            Console.WriteLine(++num1);
            Console.WriteLine();
            int num2 = 10;
            Console.WriteLine(num2++);
            Console.WriteLine();
            int num3 = 10;
            Console.WriteLine(--num3);
            Console.WriteLine();
            int num4 = 10;
            Console.WriteLine(num4--);
            Console.ReadLine();
            */

            #endregion

            #region Operador Concatenação 

            /*
            string nome = "Wilson ";
            string sobrenome = "Serafim ";
            string nomecompleto = nome + sobrenome + "Nascido no ano de: " + 1988;
            
            Console.WriteLine(nomecompleto);
            Console.ReadLine();
            */

            #endregion

            #region Operador Atribuição 

            /*
            int num1 = 10;

            num1 = num1 + 10;
            Console.WriteLine(num1);
            Console.WriteLine();
            num1 += 10;
            Console.WriteLine(num1);
            Console.WriteLine();
            num1 -= 10;
            Console.WriteLine(num1);
            Console.WriteLine();
            num1 *= 10;
            Console.WriteLine(num1);
            Console.WriteLine();
            num1 /= 10;
            Console.WriteLine(num1);
            Console.WriteLine();
            num1 %= 10;
            Console.WriteLine(num1);
            Console.ReadLine();

            //concatenação de strings
            string nome = "Wilson ";
            nome += "Serafim";

            Console.WriteLine(nome);
            Console.ReadLine();
            */

            #endregion

            #region Operador Igualdade 

            /*
            bool resul1 = 100 == 50 * 2;//retorna um valor true se ele for igual a o outro
            
            Console.WriteLine(resul1);
            Console.ReadLine();

            bool resul2 = 200 != 100 + 101; //retorna valor true se um for diferente do outro

            Console.WriteLine(resul2);
            Console.ReadLine();
            */

            #endregion

            #region  Operadores Relacionais

            /*
            bool res = 100 < 100;

            Console.WriteLine(res);
            Console.WriteLine();

            bool res1 = 100 > 100;

            Console.WriteLine(res1);
            Console.WriteLine();

            bool res2 = 100 <= 100;

            Console.WriteLine(res2);
            Console.WriteLine();

            bool res3 = 100 >= 100;

            Console.WriteLine(res3);
            Console.ReadLine();
            */

            #endregion

            #region  Operadores lógicos

            /*
            bool res1 = 100 > 100;
            bool res2 = 100 == 100;

            bool rfinalE = res1 && res2;
            bool rfinalOu = res1 || res2;

            Console.WriteLine(rfinalE);
            Console.WriteLine(rfinalOu);
            Console.ReadLine();
            */

            #endregion

            #region  Operadores lógicos

            
            bool res1 = 100 > 100;
            bool res2 = 100 == 100;

            bool rfinalE = res1 && res2;
            bool rfinalOu = res1 || res2;

            Console.WriteLine(rfinalE);
            Console.WriteLine(rfinalOu);
            Console.ReadLine();
            

            #endregion
        }
    }
}
