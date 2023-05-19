using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal sealed class Bicicleta : Veiculo
    {
        public override void Acelerar()
        {
            Console.WriteLine("A bicicleta acelerou");
        }
        public override void Parar()
        {
            Console.WriteLine("A bicicleta parou");
        }
        public void Pedalar()
        {
            
        }
    }
}
