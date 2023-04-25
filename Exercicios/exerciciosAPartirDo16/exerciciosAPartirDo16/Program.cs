using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosAPartirDo16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercicio 016


            //Console.WriteLine("-*-*-*-*-* Programa de Poder de voto *-*-*-*-*-\n");
            
            //Console.WriteLine("-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");

            //Console.ReadKey();


            #endregion

            #region Exercicio 017

            /*
            float velocidade = 0; float multa = 5; float valorMulta = 0;                       

            Console.WriteLine("-*-*-*-*-* Programa de Multa de Velocidade *-*-*-*-*-\n");
            Console.WriteLine(" Qual a velocidade aferida?\n");
            velocidade = float.Parse(Console.ReadLine());
    
            valorMulta = (velocidade - 80) * multa;
            
            if (velocidade <= 80 )
            {
                Console.WriteLine(velocidade + "km/h -- Velocidade permitida ");
            }
            else
            {
                Console.WriteLine("\nVocê ultrapassou a velocidade máxima de 80km/h em: " + (velocidade - 80) + "km/h");
                Console.WriteLine("E vai pagar uma multa de: R$" + valorMulta + "\n" );
            }
            Console.WriteLine("-*-*-*-*-*-*-*-*-* Fim do Programa  *-*-*-*-*-*-*-*-*-\n");

            Console.ReadKey();
            */

            #endregion

            #region Exercicio 018

            /*
            Console.WriteLine("-*-*-*-*-* Programa de Multa de Velocidade *-*-*-*-*-\n");
            Console.WriteLine("Qual sua idade?\n");
            int idade = int.Parse(Console.ReadLine());

            if (idade <= 16) 
            {
                Console.WriteLine("\nVocê já pode votar porém não é obrigatório!");
            }
            else if (idade <= 18 || idade < 60)
            {
                Console.WriteLine("\nVocê já pode votar, e é obrigatório!");
            }
            else if (idade >= 60)
            {
                Console.WriteLine("\nVocê ainda pode votar, porém não é obrigatório!");
            }

            Console.WriteLine("\n-*-*-*-*-*-*-*-* Fim do Programa  *-*-*-*-*-*-*-*-");

            Console.ReadKey();
            */

            #endregion

            #region Exercicio 019

            /*
            Console.WriteLine("-*-*-*-*-* Programa média do aluno *-*-*-*-*-\n");
            Console.Write("Qual nome do aluno: ");
            string aluno = Console.ReadLine();
            Console.Write("Qual a 1ª nota do aluno: " + aluno);
            float nota1 = float.Parse(Console.ReadLine());
            Console.Write("Qual a 2ª nota do aluno: " + aluno);
            float nota2 = float.Parse(Console.ReadLine());
            float media = (nota1 + nota2) / 2;

            if ( media >= 7 )
            {
                Console.WriteLine("\n A média do aluno: " + aluno + " é: " + media + " teve um bom aproveitamento");
            }
            else 
            {
                Console.WriteLine("\n A média do aluno: " + aluno + " é: " + media + " e não teve um bom aproveitamento");
            }

            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");

            Console.ReadKey();
            */


            #endregion

            #region Exercicio 020

            /*
            Console.WriteLine("-*-*-*-*-* Programa PAR ou IMPAR *-*-*-*-*-\n");
            Console.Write("Informe um número inteiro:");
            int numero = int.Parse(Console.ReadLine());

            if ( numero % 2 == 0 )
            {
                Console.WriteLine("O numero é par");
            }
            else
            {
                Console.WriteLine("O numero é impar");
            }

            Console.WriteLine("-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");

            Console.ReadKey();
            */

            #endregion

            #region Exercicio 021

            Console.WriteLine("-*-*-*-*-* Programa Ano Bisexto *-*-*-*-*-\n");
            Inicio:
            Console.Write("Informe o ano contendo os 4 digitios exemplo 1988:");
            double anobisexto = double.Parse(Console.ReadLine());
            double resultado1 = anobisexto % 400;
            double resultado2 = anobisexto % 4;
            double resultado3 = anobisexto % 100;

            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);
            Console.WriteLine(resultado3);

            if (resultado1 == 0)
            {
                Console.WriteLine("O ano é Bisexto");
            }
            else if ((resultado2 == 0) || (resultado3 != 0))
            {
                Console.WriteLine("O ano é Bisexto");
            }
            //else if (resultado3 != 0)
            //{
            //    Console.WriteLine("O ano é Bisexto");
            //}
            else
            {
                Console.WriteLine("O ano não é Bisexto");
            }

            Console.WriteLine("-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            

            Console.ReadKey();

            goto Inicio;
            

            #endregion


            #region Exercicio 016


            Console.WriteLine("-*-*-*-*-* Programa de Poder de voto *-*-*-*-*-\n");




            Console.WriteLine("-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");

            Console.ReadKey();


            #endregion

        }
    }
}
