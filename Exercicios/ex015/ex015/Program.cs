using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            15) Crie um programa que leia o número de dias trabalhados em um mês e mostre o
            salário de um funcionário, sabendo que ele trabalha 8 horas por dia e ganha R$25
            por hora trabalhada.
            */
            Console.WriteLine("-*-*-* PROGRAMA DE SALARIO *-*-*-");
            Console.Write("Favor informe o nome do funcionário: ");
            string nome = Console.ReadLine();
            Console.Write("Favor informe a quantidade de dias trabalhados no mês: ");
            int diasTrabalhados = int.Parse(Console.ReadLine());
            int valorDahora = 25;
            int QtdDeHorasPorDia = 8;
            double QtdDeHorastotal = diasTrabalhados * QtdDeHorasPorDia;
            double salario = QtdDeHorastotal * valorDahora;
            Console.WriteLine();
            Console.WriteLine("Nesse mês o funcionário: " + nome + " trabalhou " + QtdDeHorastotal + " horas e vai ter um salario de: R$" + salario);
            Console.WriteLine();
            Console.WriteLine("-*-*-* FIM DO PROGRAMA *-*-*-");
            Console.ReadLine();

        }
    }
}
