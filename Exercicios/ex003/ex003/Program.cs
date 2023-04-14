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
