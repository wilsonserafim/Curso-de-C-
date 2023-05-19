using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    internal class Recursivo
    {
        public void Execultar(string mensagem, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mensagem);
            }
        }
        public void ExecultarRecursivo(string mensagem, int n)
        {
            if (n > 0)
            {
                Console.WriteLine(mensagem);
                ExecultarRecursivo(mensagem, n - 1);
            }
        }
    }
}
