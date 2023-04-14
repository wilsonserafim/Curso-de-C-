using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-*-*-* PROGRAMA DE CALCULO DE USO DE *-*-*-");
            Console.WriteLine("-*-*-*  TINTA PARA PINTAR UMA PAREDE *-*-*-");
            Console.WriteLine("Favor a altura da parede");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Favor a largura da parede");
            float n2 = float.Parse(Console.ReadLine());
            float resultado = n1 * n2;
            float gastoTinta = resultado / 2 ;
            Console.WriteLine();
            Console.WriteLine("Vai ser preciso " + gastoTinta + " Litros de tinta");
            Console.WriteLine("para pintar a parede que tem: " + resultado + "m² (metros quadrados) ");
            Console.WriteLine();
            Console.WriteLine("-*-*-*        FIM DO PROGRAMA        *-*-*-");
            Console.ReadLine();
        }
    }
}
