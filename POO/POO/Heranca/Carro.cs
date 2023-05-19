using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Carro : Veiculo
    {
        public string VelocidadeMaxima { get; set; }

        public void LigarMotor()
        {
            Console.WriteLine("O carro ligou o motor");
        }
        public override void Acelerar()
        {
            Console.WriteLine("O carro acelerou");
        }
        public override void Parar()
        {
            Console.WriteLine("O carro parou");
        }
    }
}
