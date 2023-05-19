using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoConstrutor
{
    internal class Pessoa
    {
        public string nome;
        public string sobreNome;
        public int anoNascimento;
        public int idade;

        public Pessoa() 
        {
            nome = "Desconhecido";
            sobreNome = "Desconhecido";
            anoNascimento = 0;
            idade = 0;
        }

        public Pessoa(string nome, string sobrenome, int anoNascimento)
        {
            this.nome = nome;
            this.sobreNome = sobrenome;
            this.anoNascimento = anoNascimento;
            this.idade = Idade();
        }
        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobreNome = sobrenome;
            this.anoNascimento = 2002;
            this.idade = Idade();
        }
        private int Idade()
        {
            return 2023 - anoNascimento;
        }
    }
}
