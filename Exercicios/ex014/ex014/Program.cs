using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-*-*-* PROGRAMA DE LOCAÇÃO DE VEICULOS *-*-*-");
            Console.WriteLine("Favor informe a placa do veiculo no formato ABC-1234");
            string placa = Console.ReadLine();
            Console.WriteLine("Favor informe a quantidade de dias alugados");
            int diasLocado = int.Parse(Console.ReadLine());
            Console.WriteLine("Favor informe a quilometragem inicial");
            int kmInicial = int.Parse(Console.ReadLine());
            Console.WriteLine("Favor informe a quilometragem final");
            int kmFinal = int.Parse(Console.ReadLine());
            int kmTotal = kmFinal - kmInicial;
            float valorDiaria = 90;
            double valorKm = 0.20;
            float valorDiarias = diasLocado * valorDiaria;
            double valorTotalKm = kmTotal * valorKm;
            double valorTotalLocacao = valorDiarias + valorTotalKm;
            Console.WriteLine();
            Console.WriteLine("Valor da diaria: R$" + valorDiaria);
            Console.WriteLine();
            Console.WriteLine("Você passou " + diasLocado + " dias com o veiculo: " + placa + ", e vai pagar por isso: R$" + valorDiarias );
            Console.WriteLine();
            Console.WriteLine("Valor do KM: R$" + valorKm + " por kilometro rodado");
            Console.WriteLine();
            Console.WriteLine("Você percorreu: " + kmTotal + "km com o veiculo: " + placa + ", e vai pagar por isso: R$" + valorTotalKm );
            Console.WriteLine();
            Console.WriteLine("Valor total a pagar: R$" + valorTotalLocacao);
            Console.WriteLine();
            Console.WriteLine("-*-*-* FIM DO PROGRAMA *-*-*-");
            Console.ReadLine();

        }
    }
}
