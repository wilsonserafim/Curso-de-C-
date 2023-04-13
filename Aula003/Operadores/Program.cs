using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operadores");// ESCREVE E PULA UMA LINHA
            Console.Write("10 + 10= ");// ESCREVE E NÃO PULA UMA LINHA POIS ESTA SEM O "Line"
            Console.WriteLine( 10 + 10 );// ESCREVE E PULA UMA LINHA

            Console.Write("10 - 10= ");// ESCREVE E NÃO PULA UMA LINHA POIS ESTA SEM O "Line"
            Console.WriteLine(10 - 10);// ESCREVE E PULA UMA LINHA

            Console.Write("10 X 10= ");// ESCREVE E NÃO PULA UMA LINHA POIS ESTA SEM O "Line"
            Console.WriteLine(10 * 10);// ESCREVE E PULA UMA LINHA

            Console.Write("10 / 10= ");// ESCREVE E NÃO PULA UMA LINHA POIS ESTA SEM O "Line"
            Console.WriteLine(10 / 10);// ESCREVE E PULA UMA LINHA

            Console.Write("10 % 10= ");// ESCREVE E NÃO PULA UMA LINHA POIS ESTA SEM O "Line"
            Console.WriteLine(10 % 10);// ESCREVE E PULA UMA LINHA (RESTO DA DIVISÃO)

            Console.Write("10 < 10= ");// ESCREVE E NÃO PULA UMA LINHA POIS ESTA SEM O "Line"
            Console.WriteLine(10 < 10);// ESCREVE E PULA UMA LINHA

            Console.Write("10 <= 10= ");// ESCREVE E NÃO PULA UMA LINHA POIS ESTA SEM O "Line"
            Console.WriteLine(10 <= 10);// ESCREVE E PULA UMA LINHA

            Console.Write("10 = 10= ");// ESCREVE E NÃO PULA UMA LINHA POIS ESTA SEM O "Line"
            Console.WriteLine(10 == 10);// ESCREVE E PULA UMA LINHA

            Console.Write("10 => 10= ");// ESCREVE E NÃO PULA UMA LINHA POIS ESTA SEM O "Line"
            Console.WriteLine(10 >= 10);// ESCREVE E PULA UMA LINHA

            Console.Write("10 > 10= ");// ESCREVE E NÃO PULA UMA LINHA POIS ESTA SEM O "Line"
            Console.WriteLine(10 > 10);// ESCREVE E PULA UMA LINHA

            Console.Write("10 != 10= ");// ESCREVE E NÃO PULA UMA LINHA POIS ESTA SEM O "Line"
            Console.WriteLine(10 != 10);// ESCREVE E PULA UMA LINHA

            Console.ReadLine();//SERVE PARA AGUARDAR UMA INFORMAÇÃO DO USUARIO, UMA ENTRADA DE DADOS
        }
    }
}
