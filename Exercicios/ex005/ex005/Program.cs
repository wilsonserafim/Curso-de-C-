using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             5) Faça um programa que leia as duas notas de um aluno em uma matéria e mostre
            na tela a sua média na disciplina.
            Ex:
            Nota 1: 4.5
            Nota 2: 8.5
            A média entre 4.5 e 8.5 é igual a 6.5
            */

            Console.WriteLine("-*-*-* PROGRAMA DE MEDIA ALUNO *-*-*-");
            Console.WriteLine();
            Console.Write("Favor informe o nome do aluno: ");
            string aluno = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Favor informe a primeira nota do aluno " + aluno + ": " );
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Favor informe a segunda nota do aluno " + aluno + ": ");
            float n2 = float.Parse(Console.ReadLine());
            float resultado = (n1 + n2) / 2;
            Console.WriteLine();
            Console.WriteLine("A media do aluno: " + aluno + " é: " + resultado);
            Console.WriteLine();
            Console.WriteLine("-*-*-* FIM DO PROGRAMA *-*-*-");
            Console.ReadLine();
        }
    }
}
