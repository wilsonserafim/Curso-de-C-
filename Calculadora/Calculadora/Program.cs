using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Inicio:

            Console.Write("Digite o primeiro numero: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            double num2 = double.Parse(Console.ReadLine());

            Errada:
            Console.Write("Escolha a operação ( + ou - ou x ou / ): ");
            char op = char.Parse(Console.ReadLine());

            double resultado = 0;

            switch (op) 
            {
                default:
                    Console.WriteLine("Opção invalida\n");
                    goto Errada;

                    case '+':
                        resultado = num1 + num2;
                        Console.WriteLine("O resultado da Soma de " + num1 + " + " + num2 + " = " + resultado);
                    break;

                    case '-':
                        resultado = num1 - num2;
                        Console.WriteLine("O resultado da Subtração de " + num1 + " + " + num2 + " = " + resultado);
                        break;

                    case '*':
                    case 'x':
                    case 'X':
                        resultado = num1 * num2;
                        Console.WriteLine("O resultado da Multiplicação de " + num1 + " x " + num2 + " = " + resultado);
                        break;


                    case '/':
                    case ':':

                        if (num1 == 0)
                        {
                            Console.WriteLine("Não é possivel dividir " + num1 + " por 0 (zero)");
                        }
                        else
                        {
                            resultado = num1 / num2;
                            Console.WriteLine("O resultado da divisão de " + num1 + " / " + num2 + " = " + resultado);  
                        }
                        
                        break;
            }

            Console.WriteLine("Deseja continuar calculando? ");
            Console.WriteLine("Se sim digite \"s\" se não digite \"n\" ");
            char operacao = char.Parse(Console.ReadLine());
            
            switch (operacao)
            {
                case 'S':
                case 's':
                    goto Inicio;

                case 'N':
                case 'n':
                    Console.WriteLine(" Calculadora encerrada pressione enter pra fechar ");
                    break;
            }
            Console.ReadLine();
        }
    }
}
