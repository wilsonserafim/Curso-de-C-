﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            9) Faça um algoritmo que leia quanto dinheiro uma pessoa tem na carteira (em R$)
            e mostre quantos dólares ela pode comprar. Considere US$1,00 = R$3,45.
            */
            Console.WriteLine("-*-*-* PROGRAMA DE CONVERSÃO DE REAL -> DOLAR *-*-*-");
            Console.WriteLine("Favor informe a quantidade de reais que você possui");
            Console.Write("R$");
            double reais = double.Parse(Console.ReadLine());
            Console.WriteLine("Favor informe o cambio atual do dolar:");
            Console.Write("U$");
            double valorDolar = double.Parse(Console.ReadLine());
            double resultado = reais / valorDolar;
            Console.WriteLine();
            Console.WriteLine("Você pode comprar até: U$" + Math.Round(resultado, 2).ToString() + " Dolares. tendo base um cambio de: U$" + valorDolar);
            Console.WriteLine();
            Console.WriteLine("-*-*-* FIM DO PROGRAMA *-*-*-");
            Console.ReadLine();
        }
    }
}
