using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            2) Faça um programa que leia o nome de uma pessoa e mostre uma mensagem de boasvindas
            para ela:
            Ex:
            Qual é o seu nome? João da Silva
            Olá João da Silva, é um prazer te conhecer!
            */
            Console.WriteLine("Qual é o seu nome?");
            String nome = Console.ReadLine();
            Console.WriteLine("Olá " + nome + ", é um prazer em te conhecer!");
            Console.ReadLine();
        }
    }
}
