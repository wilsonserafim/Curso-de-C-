using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            3) Crie um programa que leia o nome e o salário de um funcionário, mostrando no
            final uma mensagem.
            Ex:
            Nome do Funcionário: Maria do Carmo
            Salário: 1850,45
            O funcionário Maria do Carmo tem um salário de R$1850,45 em Junho.
            */
            Console.Write("Nome do funcionário: ");
            string funcionario = Console.ReadLine();
            Console.Write("Salário: ");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("O funcionário " + funcionario + " tem um salário de R$" + salario + " em Março.");
            Console.ReadLine();
        }
    }
}
