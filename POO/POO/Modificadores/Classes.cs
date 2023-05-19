using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores
{
    internal class Teste
    {
        protected string nome;
        public string sobreNome;

        private void Metodo1() { }
        public void Executar() { } 

    }

    class Humano
    {
        protected string nome;
        private string sobreNome;
        internal int idade;
    }

    class Homem : Humano 
    {
        public void Metodo() 
        {
            nome = "";
        }    
    }
}
