using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoDasClasses
{
    internal class Metodos
    {
        // Metodos Simples
        public void Cumprimentar() 
        {
            Console.WriteLine(" Olá Seja bem vindo!");
        }

        //Metodos com parametros
        public void Somar(int num1, int num2) 
        {
            int resultado = num1 + num2;
            Console.WriteLine("A soma é: " + resultado);
        }

        public void Apresentar(string nome, int idade)
        {
            Console.WriteLine("Meu nome é " +  nome + " e tenho " + idade + " anos");   
        }

        //Passagem de parametros por valor
        public void AumentarValor (int valor) 
        {
            valor += 10;
            Console.WriteLine("Valor final (por valor) é: " + valor);
        }

        //Passagem de parametros por valor
        public void AumentarRef(ref int valor)
        {
            valor += 10;
            Console.WriteLine("Valor final (por referencia) é: " + valor);
        }

        //metodos com retorno de valores
        public string MontaNome(string nome, string sobreNome)
        {
            //string nomeCompleto = nome + " " + sobreNome;
            //return nomeCompleto;
            return nome + " " + sobreNome; //simplificado
        }

        public int CodigoChar(char caractere) 
        {
            //int codigo = (int)caractere;
            //return codigo;
            return caractere; //converção implicita 
        }

        public double ValorPi() 
        {
            return 3.1415;
        }

        //Sobregarga de metodos (Overloading)
        public void Cumprimentar(string nome)
        {
            Console.WriteLine(" Olá " + nome);

        }
        public void Cumprimentar(string nome, int hora)
        {
            string mensagem = hora < 12 ? "Bom dia " + nome : "Boa tarde " + nome;
            Console.WriteLine(mensagem);
        }

        public bool Comparar (int txt1, int txt2) 
        {
            return txt1 == txt2;
        }
        public bool Comparar(string txt1, string txt2)
        {
            return txt1 == txt2;
        }
    }
}
