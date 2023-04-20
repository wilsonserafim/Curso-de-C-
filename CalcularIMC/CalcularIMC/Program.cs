using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float peso, altura, imc;

            Console.WriteLine("*/*/*/*/*/*/ Programa de Calculo de IMC */*/*/*/*/*/ ");
            Console.WriteLine();
            Console.WriteLine("Informe seu peso em quilogramas e pressione enter ");
            Console.WriteLine("Ex.: 80,4");
            peso = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Informe sua altura em metros e pressione enter ");
            Console.WriteLine("Ex.: 1,65");
            altura = float.Parse(Console.ReadLine());

            //logica

            imc = peso / (altura * altura);
            Console.WriteLine("Seu IMC é: " + imc);

            if (imc < 16.9)
            {
                Console.WriteLine("Muito abaixo do peso");
            }
            else if (imc < 18.4)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc < 24.9)
            {
                Console.WriteLine("Peso normal");
            }
            else if (imc < 29.9)
            {
                Console.WriteLine("Acima do peso");
            }
            else if (imc < 34.9)
            {
                Console.WriteLine("Obesidade grau I");
            }
            else if (imc < 40)
            {
                Console.WriteLine("Obesidade grau II");
            }
            else
            {
                Console.WriteLine("Obesidade grau III");
            }
            Console.WriteLine();
            Console.WriteLine("*/*/*/*/*/*/ Programa de Calculo de IMC */*/*/*/*/*/ ");
            Console.ReadKey();          
        }
    }
}
