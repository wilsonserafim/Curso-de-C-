using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosAPartirDo50
{
    class Procedimentos
    {
        public void Gerador1()
        {
            Console.WriteLine("+-------=======------+");
            Console.WriteLine("      Olá Mundo!!!    ");
            Console.WriteLine("+-------=======------+");

        }
        public void Gerador2(string mensagem)
        {
            Console.WriteLine("+-------=======------+");
            Console.WriteLine(mensagem);
            Console.WriteLine("+-------=======------+");

        }
        public void Gerador3(string mensagem3, int n)
        {
            Console.WriteLine("+-------=======------+");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mensagem3);
            }
            Console.WriteLine("+-------=======------+");

        }
        public void Gerador4(string mensagem4, int n, int b)
        {
            if (b == 1)
            {
                Console.WriteLine("+-------=======------+");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(mensagem4);
                }
                Console.WriteLine("+-------=======------+");
            }
            if (b == 2)
            {
                Console.WriteLine("~~~~~~~~:::::::~~~~~~~");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(mensagem4);
                }
                Console.WriteLine("~~~~~~~~:::::::~~~~~~~");
            }
            if (b == 3)
            {
                Console.WriteLine("<<<<<<<<------->>>>>>>");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(mensagem4);
                }
                Console.WriteLine("<<<<<<<<------->>>>>>>");
            }


        }
        public void Somador(double n1, double n2)
        {          
            Console.WriteLine("O somatorio dos dois numeros é " + (n1 + n2));
        }
        public void Maior(double n1, double n2)
        {
            if (n1 > n2)
            {
                Console.WriteLine(" o numero: " + n1 + " é maior que: " + n2);
            }
            else 
            {
                Console.WriteLine(" o numero: " + n2 + " é maior que: " + n1);
            }
        }
        public void ParOuImpar(double n1)
        {
            if (n1 % 2 == 0)
            {
                Console.WriteLine(" O número: " + n1 + " é Par ");
            }
            else
            {
                Console.WriteLine(" O número: " + n1 + " NÃO é Par ");
            }
        }
        public void Contador(int n1, int n2, int n3)
        {
            for (int i = n1; i < n2; i += n3)
            {
                Console.Write(" " + i + ">> ");
            }
        }
        public void Fibonacci(int n1)
        {
            int fb1, fb2, fb3;
            fb1 = 1;
            fb2 = 1;
            fb3 = 1;
            int[] fibo = new int[n1];

            for (int i = 0; i < n1;)
            {
                fibo[i] = fb1;
                Console.Write(" " + fibo[i] + " ");
                fb3 = fb1 + fb2;
                fb1 = fb2;
                fb2 = fb3;
                i++;
            }
        }


    }
}
