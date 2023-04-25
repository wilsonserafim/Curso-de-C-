using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Classes e Objetos
            /*
            MinhaClasse mClasse = new MinhaClasse();
            MinhaClasse m2 = null;

            OutraClass outra = new OutraClass();
            OutraClass outra2 = outra;
            */
            #endregion

            #region Atributo das classes

            /*
            Pessoa p1 = new Pessoa();
            p1.nome = "Wilson";
            p1.sobreNome = "Serafim";
            p1.anoNascimento = 1988;

            Pessoa p2 = new Pessoa()
            {
                nome = "Giovanna",
                sobreNome = "Albuquerque",
                anoNascimento = 2013
            };

            p1.nome = "Logan"; //podemos alterar o valor dos atributos apenas referenciando
                               //como foi feito aqui o nome que era "Wilson" passou a ser "Logan"

            Console.WriteLine("Pessoa 1 nome: " + p1.nome);
            Console.WriteLine("Pessoa 1 sobrenome: " + p1.sobreNome);
            Console.WriteLine("Pessoa 1 ano de nascimento: " + p1.anoNascimento);
            
            Console.WriteLine();

            Console.WriteLine("Pessoa 2 nome: " + p2.nome);
            Console.WriteLine("Pessoa 2 sobrenome: " + p2.sobreNome);
            Console.WriteLine("Pessoa 2 ano de nascimento: " + p2.anoNascimento);

            Console.ReadKey();
            */

            #endregion

            #region Metodo Simples

            /*
            Pessoa p1 = new Pessoa();
            p1.nome = "Wilson";
            p1.sobreNome = "Serafim";
            p1.anoNascimento = 1988;

            Pessoa p2 = new Pessoa()
            {
                nome = "Giovanna",
                sobreNome = "Albuquerque",
                anoNascimento = 2013
            };

            p1.nome = "Logan"; //podemos alterar o valor dos atributos apenas referenciando
                               //como foi feito aqui o nome que era "Wilson" passou a ser "Logan"

            Console.WriteLine("Pessoa 1 nome: " + p1.nome);
            Console.WriteLine("Pessoa 1 sobrenome: " + p1.sobreNome);
            Console.WriteLine("Pessoa 1 ano de nascimento: " + p1.anoNascimento);
            p1.Cumprimentar(); //aqui chamamos um metodo simples criano na classe Pessoa
            
            Console.WriteLine();

            Console.WriteLine("Pessoa 2 nome: " + p2.nome);
            Console.WriteLine("Pessoa 2 sobrenome: " + p2.sobreNome);
            Console.WriteLine("Pessoa 2 ano de nascimento: " + p2.anoNascimento);
            p2.Cumprimentar();//aqui chamamos um metodo simples criano na classe Pessoa

            Console.ReadKey();
            */

            #endregion

            #region Metodo Simples

            
            Pessoa p1 = new Pessoa();
            p1.nome = "Wilson";
            p1.sobreNome = "Serafim";
            p1.anoNascimento = 1988;

            Pessoa p2 = new Pessoa()
            {
                nome = "Giovanna",
                sobreNome = "Albuquerque",
                anoNascimento = 2013
            };

            p1.nome = "Logan"; //podemos alterar o valor dos atributos apenas referenciando
                               //como foi feito aqui o nome que era "Wilson" passou a ser "Logan"

            Console.WriteLine("Pessoa 1 nome: " + p1.nome);
            Console.WriteLine("Pessoa 1 sobrenome: " + p1.sobreNome);
            Console.WriteLine("Pessoa 1 ano de nascimento: " + p1.anoNascimento);
            p1.Cumprimentar(); //aqui chamamos um metodo simples criano na classe Pessoa
            
            Console.WriteLine();

            Console.WriteLine("Pessoa 2 nome: " + p2.nome);
            Console.WriteLine("Pessoa 2 sobrenome: " + p2.sobreNome);
            Console.WriteLine("Pessoa 2 ano de nascimento: " + p2.anoNascimento);
            p2.Cumprimentar();//aqui chamamos um metodo simples criano na classe Pessoa

            Console.ReadKey();
            

            #endregion

        }
    }

    class MinhaClasse
    {

    }
}
