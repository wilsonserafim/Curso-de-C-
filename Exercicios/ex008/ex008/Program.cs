using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-*-*-* PROGRAMA DE CONVERSÃO DE MEDIDAS *-*-*-");
            Console.WriteLine("informe a distancia em metros");
            float n1 = float.Parse(Console.ReadLine());
            float n1EmKm = n1 / 1000;
            float n1EmHm = n1 / 100;
            float n1EmDam = n1 / 10;
            float n1EmDm = n1 * 10;
            float n1EmCm = n1 * 100;
            float n1EmMm = n1 * 1000;
            Console.WriteLine();
            Console.WriteLine("A distância de " + n1 + "m corresponde a:");
            Console.WriteLine();
            Console.WriteLine(n1EmKm + "Km");
            Console.WriteLine();
            Console.WriteLine(n1EmHm + "Hm");
            Console.WriteLine();
            Console.WriteLine(n1EmDam + "Dam");
            Console.WriteLine();
            Console.WriteLine(n1EmDm + "dm");
            Console.WriteLine();
            Console.WriteLine(n1EmCm + "cm");
            Console.WriteLine();
            Console.WriteLine(n1EmMm + "mm");
            Console.WriteLine();
            Console.WriteLine("-*-*-* FIM DO PROGRAMA *-*-*-");
            Console.ReadLine();
        }
    }
}
