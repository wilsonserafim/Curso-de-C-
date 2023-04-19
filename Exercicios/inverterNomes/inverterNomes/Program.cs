using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inverterNomes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Conversão Implicita

            /*
            string nome1, nome2, nome3, nome4, aux;
                    
            Console.Write("Digite o 1º nome e pressione enter: ");
            nome1 = Console.ReadLine();

            Console.Write("Digite o 1º nome e pressione enter: ");
            nome2 = Console.ReadLine();

            Console.Write("Digite o 1º nome e pressione enter: ");
            nome3 = Console.ReadLine();

            Console.Write("Digite o 1º nome e pressione enter: ");
            nome4 = Console.ReadLine();
            Console.WriteLine();

            //lógica

            aux = nome1;
            nome1 = nome4;
            nome4 = aux;
            aux = nome2;
            nome2 = nome3;
            nome3 = aux;


            //Saída
            Console.WriteLine(nome1);
            Console.WriteLine(nome2);
            Console.WriteLine(nome3);
            Console.WriteLine(nome4);

            Console.ReadLine();

            */
            #endregion


            #region Conversão Explicita
            /*
             
            ushort num1 = 500;
            byte num2 = (byte)num1;

            float num3 = 2500.786f;
            int num4 = (int)num3;

            char letra = (char)97;

            Console.WriteLine("O número 1 do tipo unsort é: " + num1);
            Console.WriteLine();
            Console.WriteLine("O número 1 convertido de unshort para byte é: " + num2);
            Console.WriteLine();
            Console.WriteLine("O número 3 do tipo float é: " + num3);
            Console.WriteLine();
            Console.WriteLine("O número 3 convertido de float para int é: " + num4);
            Console.WriteLine();
            Console.WriteLine("Aqui temos um numero (char) convertido em uma letra: " + letra);

            Console.ReadLine();

            */
            #endregion


            #region Metodo Parse

            /*
            String txtNumero = "1985";

            int numero = int.Parse(txtNumero);

            byte num1 = byte.Parse("120");

            double num2 = double.Parse("126623,57"); //nesse caso temos que colocar a virula em vez do ponto, porem quando formos adicionar diretamente na variavel pode ser ponto.

            float num3  = float.Parse("457,75");

            Console.WriteLine();
            Console.WriteLine(numero);
            Console.WriteLine();
            Console.WriteLine(num1);
            Console.WriteLine();
            Console.WriteLine(num2);
            Console.WriteLine();
            Console.WriteLine(num3);
            Console.WriteLine();

            Console.ReadLine();

            */

            #endregion


            #region Classe Convert

            /*
            String texto = Convert.ToString(2500);

            double num1 = Convert.ToDouble(false);

            int num2 = Convert.ToInt32('C');
                 
            Console.WriteLine();
            Console.WriteLine(texto);
            Console.WriteLine();
            Console.WriteLine(num1);
            Console.WriteLine();
            Console.WriteLine(num2);
            Console.WriteLine();

            Console.ReadLine();
            */

            #endregion







        }
    }
}
