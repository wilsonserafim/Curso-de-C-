using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            13) Faça um algoritmo que leia o salário de um funcionário, calcule e mostre o
            seu novo salário, com 15% de aumento.
            */
            Console.WriteLine("-*-*-* PROGRAMA DE AUMENTO DE SALARIO *-*-*-");
            Console.WriteLine();
            Console.Write("Favor informe o nome do funcionário: ");
            string funcionario = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Favor informe o Salario do funcionário: ");
            float salario = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Favor informe o Salario do funcionário: ");
            float percentualDeAlmento = float.Parse(Console.ReadLine());
            Console.WriteLine();
            float promocao = (percentualDeAlmento / 100) * salario;
            float novoSalario = salario + promocao;
            Console.WriteLine();
            Console.WriteLine("O funcionario: " + funcionario + " recebia: R$" + salario );
            Console.WriteLine("com o aumento de: " + percentualDeAlmento + "% equivalente a : R$" + Math.Round(promocao, 2).ToString());
            Console.WriteLine("o mesmo agora recebe: " + Math.Round(novoSalario, 2).ToString());
            Console.WriteLine();
            Console.WriteLine("-*-*-* FIM DO PROGRAMA *-*-*-");
            Console.ReadLine();
        }
    }
}
