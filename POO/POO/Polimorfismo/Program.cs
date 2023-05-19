using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Forma a = new Forma();
            Forma b = new Triangulo();
            Forma c = new Circulo();
            Forma d = new Retangulo();

            //a.Desenhar();
            //Console.WriteLine("Forma \n");
            b.Desenhar();
            Console.WriteLine("Triangulo\n");
            c.Desenhar();
            Console.WriteLine("Circulo\n");
            d.Desenhar();
            Console.WriteLine("Retangulo\n");


            Console.ReadLine();


        }
    }
}
