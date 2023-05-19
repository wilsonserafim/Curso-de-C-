﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    abstract public class Forma
    {
        public int x { get; private set; }
        public int y { get; private set; }
        public int Altura { get;  set; }
        public int Largura { get; set; }
        public int Raio { get; set; }

        public virtual void Desenhar()
        {
            Console.WriteLine("Preparando-se para desenhar");
        }

        public virtual void Area()
        {
            int area = Largura * Altura;
            Console.WriteLine("Area: " + area);
        }
    }
    public class Circulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Desenhando um Circulo");
        }

        public override void Area()
        {
            double area = 3.14 * (Raio * Raio);
            Console.WriteLine("Area do Circulo " + area);
        }
    }
    public class Retangulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Desenhando um Retangulo");
        }

        public override void Area()
        {
            base.Area();
        }
    }
    public class Triangulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Desenhando um Triangulo");
        }

        public override void Area()
        {
            int area = (Largura * Altura) / 2;
            Console.WriteLine("Area do Triangulo " + area);
        }
    }
}
