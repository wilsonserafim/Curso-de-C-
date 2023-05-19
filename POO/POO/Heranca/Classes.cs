using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Humano
    {
        public virtual void Olhos()
        {
            Console.WriteLine("Humano.olhos");
        }
        public virtual void Cabelos()
        {
            Console.WriteLine("Humano.cabelos");
        }
    }
    internal class Pessoa : Humano 
    {
        public sealed override void Olhos()
        {
            Console.WriteLine("Pessoa.olhos");
        }
        public override void Cabelos()
        {
            Console.WriteLine("Pessoa.cabelos");
        }
    }
    internal class Homem : Pessoa 
    {
        //public override void Olhos()
        //{
        //    Console.WriteLine("Homem.olhos");
        //}
        public override void Cabelos()
        {
            Console.WriteLine("Homem.cabelos");
        }
    }
}
