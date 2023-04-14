using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             16) [DESAFIO] Escreva um programa para calcular a redução do tempo de vida de um
             fumante. Pergunte a quantidade de cigarros fumados por dias e quantos anos ele
             já fumou. Considere que um fumante perde 10 min de vida a cada cigarro. Calcule
             quantos dias de vida um fumante perderá e exiba o total em dias.
            */

            Console.WriteLine("-*-*-* PROGRAMA FUMANTE *-*-*-");
            Console.WriteLine();
            Console.WriteLine("Favor informe sua idade atual: ");
            int idadeAtual = int.Parse(Console.ReadLine());
            Console.WriteLine("com quantos anos começou a fumar: ");
            int inicioFumo = int.Parse(Console.ReadLine());
            Console.WriteLine("com quantos cigarros fuma por dia: ");
            int fumaPordia = int.Parse(Console.ReadLine());
            int anosQueFuma = idadeAtual - inicioFumo;
            double diasQueFuma = anosQueFuma * 365;
            double totalDeCigarrosFumados = diasQueFuma * fumaPordia;
            double totalDeMinutosPerdidos = totalDeCigarrosFumados * 10;
            double totalDeHorasPerdidas = totalDeMinutosPerdidos / 60;
            double totalDeDiasPerdidos = totalDeHorasPerdidas / 24;
            double totalDeAnosPerdidos = totalDeDiasPerdidos / 365;
            Console.WriteLine();
            Console.WriteLine("Você fuma há " + anosQueFuma + " anos");
            Console.WriteLine();
            Console.WriteLine("Nesse periodo você fumou uma média de: " + totalDeCigarrosFumados + " cigarros");
            Console.WriteLine();
            Console.WriteLine("cada cigarro fumado corresponde a -10 minutos de vida");
            Console.WriteLine();
            Console.WriteLine("então você perdeu uma média de: " + totalDeHorasPerdidas + " horas");
            Console.WriteLine();
            Console.WriteLine("e uma média de: " + Math.Round(totalDeDiasPerdidos, 0).ToString() + " dias");
            Console.WriteLine();
            Console.WriteLine("e isso corresponde a: " + totalDeAnosPerdidos + " anos");
            Console.WriteLine();
            Console.WriteLine("-*-*-* FIM DO PROGRAMA *-*-*-");
            Console.ReadLine();

        }
    }
}
