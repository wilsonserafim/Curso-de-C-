using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeTemperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c, f, k;

            Console.WriteLine("*_*_*_*_*_* CONVERSOR DE TEMPERATURAS *_*_*_*_*_*");
            Console.WriteLine();
            Console.Write("Insira a temperatura em Celcius: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();

            //formula de Fahrenheit F = ( GrausCelcius × 9/5) + 32 = 32 °F
            f = ((c * 9) / 5) + 32;
            Console.WriteLine(" A temperatura " + c + "°C" + " transformada em Fahrenheit é igual a " + f + "°F");
            Console.WriteLine();

            //formula de Kelvin  K = GrausCelcius + 273
            k = c + 273.5;
            Console.WriteLine(" A temperatura " + c + "°C" + " transformada em Kelvin é igual a " + k + "K");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");
            Console.ReadLine();


        }
    }
}
