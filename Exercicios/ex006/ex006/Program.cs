﻿using System;
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
            6) Faça um programa que leia um número inteiro e mostre o seu antecessor e seu
            sucessor.
            Ex:
            Digite um número: 9
            O antecessor de 9 é 8
            O sucessor de 9 é 10
            */
            Console.WriteLine("-*-*-* PROGRAMA SUCESSOR E ANTECESSOR *-*-*-");
            Console.WriteLine("Favor informe um número");
            int n1 = int.Parse(Console.ReadLine());
            int sucessor = n1 + 1;
            int antecessor = n1 - 1;
            Console.WriteLine();
            Console.WriteLine("O sucessor de " + n1 + " é " + sucessor);
            Console.WriteLine();
            Console.WriteLine("O antesucessor de " + n1 + " é " + antecessor);
            Console.WriteLine();
            Console.WriteLine("-*-*-* FIM DO PROGRAMA *-*-*-");
            Console.ReadLine();
        }
    }
}
