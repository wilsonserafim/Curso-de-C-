using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades
{
    internal class Teste
    {
        //Definição de campo
        private string _nome;
        public string SobreNome { get; } = "Serafim";
        
        private int _idade;

        //Definição de uma propiedade
        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                _nome = value;
            }
        }
        public int Idade
        {
            get
            {
                return _idade;
            }

            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Idade não pode ser inferior a 18 anos");
                }
                else
                {
                    _idade = value;
                }
            
            }
        }

        public void Apresentar()
        {
            if (_nome != "") 
            {
                Console.WriteLine("Bem vindo " + _nome);
            }
        }
    }
}
