using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CompraOnlineUser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("/-*/-*/-*/-*/-*/ COMPRA ONLINE /-*/-*/-*/-*/-*/");
            Console.WriteLine("/-*/-*/-*/-*/-*/ DADOS DO USUÁRIO /-*/-*/-*/-*/-*/");
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite seu Saldo: ");
            double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("/-*/-*/-*/-*/-*/ DADOS DO USUÁRIO /-*/-*/-*/-*/-*/");
            Console.WriteLine();

            Console.WriteLine("/-*/-*/-*/-*/-*/ DADOS DO PRODUTO /-*/-*/-*/-*/-*/");
            Console.Write("Digite o nome do produto: ");
            string produto = Console.ReadLine();
            Console.Write("Digite o valor do produto: ");
            double valorProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double saldoFinal = ( valorProduto - saldo);
            
            if (saldoFinal < 0)
                {
                saldoFinal = saldoFinal * -1; //serve para que se o saldo ficar negativo ele converter e ficar positivo 
                }

            Console.WriteLine("/-*/-*/-*/-*/-*/ RESULTADO /-*/-*/-*/-*/-*/");
            Console.WriteLine(" Olá " + nome);
            Console.WriteLine(" Seu saldo inicial é: " + saldo );

            if (valorProduto > saldo)
            {
                Console.WriteLine(" O seu saldo não da pra comprar o produto: " + produto + " Preço: " + valorProduto + " Pois o preço é maior que o seu saldo em: " + saldoFinal);
            }
            else
            {
                Console.WriteLine(" O seu saldo da pra comprar esse produto: " + produto + " Preço: " + valorProduto + " e você ficara com um saldo de: " + saldoFinal);
            }
            Console.ReadLine();
        }
    }
}
