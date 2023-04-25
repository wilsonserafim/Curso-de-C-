using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesObjetos
{
    internal class Pessoa
    {
        //atributos ou campos da classe pessoa
        public string nome;
        public string sobreNome;
        public int anoNascimento;

        //metodos simples
        public void Cumprimentar () 
        {
            Console.WriteLine("Ola eu sou " + nome + " " + sobreNome);
        }
    }
}
