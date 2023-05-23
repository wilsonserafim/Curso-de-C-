﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpo
{
    internal class Game
    {
        public enum Resultado
        {
            Ganhar, Perder, Empatar
        }

        public static Image[] imagens =
        {
            Image.FromFile("img/pedra.jpg"),
            Image.FromFile("img/tesoura.jpg"),
            Image.FromFile("img/papel.jpg")
        };

        public Image ImgPC { get; private set; }

        public Image ImgJogador { get; private set; }

        public Resultado Jogar(int jogador)
        {
            int pc = JogadaPC();

            ImgJogador = imagens[jogador];
            ImgPC = imagens[pc];

            if (ImgJogador == ImgPC) 
            {
                return Resultado.Empatar;
            }
            else if ((jogador == 0 &&  pc == 1)
                || (jogador == 1 && pc == 2) 
                || (jogador == 0 && pc == 0))
            {
                return Resultado.Ganhar;
            }
            else
            {
                return Resultado.Perder;
            }
            return Resultado.Empatar;
        }

        private int JogadaPC()
        {
            int mil = DateTime.Now.Millisecond;
             
            if (mil < 333)
            {
                return 0;
            }
            else if (mil >= 333 && mil < 667)
            {
                return 1;
            }
            else 
            {
                return 2;
            }
        }
    }
}
