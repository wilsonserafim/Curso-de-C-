using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            7) Crie um algoritmo que leia um número real e mostre na tela o seu dobro e a
            sua terça parte.
            Ex:
            Digite um número: 3.5
            O dobro de 3.5 é 7.0
            A terça parte de 3.5 é 1.16666
            */
            Console.WriteLine("-*-*-* PROGRAMA MULTIPLICAÇÃO DE NUMEROS REAIS *-*-*-");
            Console.WriteLine("Favor informe um número real ou seja com virgula");
            double n1 = double.Parse(Console.ReadLine());
            double dobro = n1 * 2 ;
            double tercaParte = n1 / 3;
            Console.WriteLine();
            Console.WriteLine("O dobro de " + n1 + " é " + dobro );
            Console.WriteLine();
            Console.WriteLine("A terça parte de " + n1 + " é " + tercaParte );
            Console.WriteLine();
            Console.WriteLine("-*-*-* FIM DO PROGRAMA *-*-*-");
            Console.ReadLine();
        }
    }
}
