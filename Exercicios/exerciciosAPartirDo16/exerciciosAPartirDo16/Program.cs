using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosAPartirDo16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercicio 016


            //Console.WriteLine("-*-*-*-*-* Programa de Poder de voto *-*-*-*-*-\n");



            //Console.WriteLine();
            //Console.WriteLine("-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");


            //Console.ReadKey();


            #endregion

            #region Exercicio 017

            /*
            float velocidade = 0; float multa = 5; float valorMulta = 0;                       

            Console.WriteLine("-*-*-*-*-* Programa de Multa de Velocidade *-*-*-*-*-\n");
            Console.WriteLine(" Qual a velocidade aferida?\n");
            velocidade = float.Parse(Console.ReadLine());
    
            valorMulta = (velocidade - 80) * multa;
            
            if (velocidade <= 80 )
            {
                Console.WriteLine(velocidade + "km/h -- Velocidade permitida ");
            }
            else
            {
                Console.WriteLine("\nVocê ultrapassou a velocidade máxima de 80km/h em: " + (velocidade - 80) + "km/h");
                Console.WriteLine("E vai pagar uma multa de: R$" + valorMulta + "\n" );
            }
            Console.WriteLine("-*-*-*-*-*-*-*-*-* Fim do Programa  *-*-*-*-*-*-*-*-*-\n");

            Console.ReadKey();
            */

            #endregion

            #region Exercicio 018

            /*
            Console.WriteLine("-*-*-*-*-* Programa de Multa de Velocidade *-*-*-*-*-\n");
            Console.WriteLine("Qual sua idade?\n");
            int idade = int.Parse(Console.ReadLine());

            if (idade <= 16) 
            {
                Console.WriteLine("\nVocê já pode votar porém não é obrigatório!");
            }
            else if (idade <= 18 || idade < 60)
            {
                Console.WriteLine("\nVocê já pode votar, e é obrigatório!");
            }
            else if (idade >= 60)
            {
                Console.WriteLine("\nVocê ainda pode votar, porém não é obrigatório!");
            }

            Console.WriteLine("\n-*-*-*-*-*-*-*-* Fim do Programa  *-*-*-*-*-*-*-*-");

            Console.ReadKey();
            */

            #endregion

            #region Exercicio 019

            /*
            Console.WriteLine("-*-*-*-*-* Programa média do aluno *-*-*-*-*-\n");
            Console.Write("Qual nome do aluno: ");
            string aluno = Console.ReadLine();
            Console.Write("Qual a 1ª nota do aluno: " + aluno);
            float nota1 = float.Parse(Console.ReadLine());
            Console.Write("Qual a 2ª nota do aluno: " + aluno);
            float nota2 = float.Parse(Console.ReadLine());
            float media = (nota1 + nota2) / 2;

            if ( media >= 7 )
            {
                Console.WriteLine("\n A média do aluno: " + aluno + " é: " + media + " teve um bom aproveitamento");
            }
            else 
            {
                Console.WriteLine("\n A média do aluno: " + aluno + " é: " + media + " e não teve um bom aproveitamento");
            }

            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");

            Console.ReadKey();
            */


            #endregion

            #region Exercicio 020

            /*
            Console.WriteLine("-*-*-*-*-* Programa PAR ou IMPAR *-*-*-*-*-\n");
            Console.Write("Informe um número inteiro:");
            int numero = int.Parse(Console.ReadLine());

            if ( numero % 2 == 0 )
            {
                Console.WriteLine("O numero é par");
            }
            else
            {
                Console.WriteLine("O numero é impar");
            }

            Console.WriteLine("-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");

            Console.ReadKey();
            */

            #endregion

            #region Exercicio 021

            /*
            Console.WriteLine("-*-*-*-*-* Programa Ano Bisexto *-*-*-*-*-\n");
            Inicio:
            Console.Write("Informe o ano contendo os 4 digitios exemplo 1988:");
            double ano = double.Parse(Console.ReadLine());
            double resultado1 = ano % 400;
            double resultado2 = ano % 4;
            double resultado3 = ano % 100;

            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);
            Console.WriteLine(resultado3);

            if ( (ano % 400 == 0) || ( (ano % 4 ==0) && (ano % 100 != 0) ) )
            {
                Console.WriteLine("O ano " + ano + " é Bisexto");
            }
            else
            {
                Console.WriteLine("O ano " + ano + " não é Bisexto");
            }

            Console.WriteLine("-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            

            Console.ReadKey();

            goto Inicio;
            */

            #endregion

            #region Exercicio 022

            /*
            Console.WriteLine("-*-*-*-*-* Programa de alistamento militar *-*-*-*-*-\n");
            Console.Write("Favor informe seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("\nFavor informe sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            int anosFalta = 18 - idade;
            int anosPassou = idade - 18;

            if (idade >= 18) 
            {
                Console.WriteLine("\nOlá " + nome + " Seja bem vindo você deve ir se alistar.");
                Console.WriteLine("Caso não tenha se alistado você esta a: " + anosPassou + " anos sem se alistar\n");
            }
            else
            {
                Console.WriteLine("\nOlá " + nome + " faltam " + anosFalta + " anos, para você se alistar.");
            }



            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");

            Console.ReadLine();
            */

            #endregion

            #region Exercicio 023

            /*
            Console.WriteLine("-*-*-*-*-* Programa desconto Dia das Mulheres *-*-*-*-*-\n");
            Console.Write("Olá favor informe seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("\nOlá favor informe seu sexo \"homem\" ou \"mulher\": ");
            string sexo = Console.ReadLine();
            Console.Write("\nOlá favor informe o valor de suas compras: ");
            double valor = double.Parse(Console.ReadLine());
            double descH = 5;
            double descM = 13;
            double descTotalM = (valor * descM) / 100;
            double descTotalH = (valor * descH) / 100;
            double valorTotalM = valor - descTotalM;
            double valorTotalH = valor - descTotalH;
            Console.WriteLine(descTotalM);
            Console.WriteLine(descTotalH);
            Console.WriteLine(valorTotalM);
            Console.WriteLine(valorTotalH);

            if ((sexo == "mulher") || (sexo == "Mulher"))
            {
                Console.WriteLine("\n Olá " + nome + " você ganhou um desconto de "
                                  + descM + "% e vai pagar um valor total de: R$" + valorTotalM);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("\n Olá " + nome + " você ganhou um desconto de "
                                  + descH + "% e vai pagar um valor total de: R$" + valorTotalH);
                Console.WriteLine();
            }
            Console.WriteLine("-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");

            Console.ReadKey();
            */


            #endregion

            #region Exercicio 024

            /*
            Console.WriteLine("-*-*-*-*-* Programa de Calculo de distancia *-*-*-*-*-\n");
            Console.Write(" Olá Qual seu nome? ");
            string nome = Console.ReadLine();
            Console.Write("\n Qual a distancia em KM que vc vai percorrer ");
            double distancia = double.Parse(Console.ReadLine());
            Console.WriteLine("\n O custo até 200km é R$0,50 por km e R$0,45 por km acima de 200km. ");
            double valorAPagar = 0;
            
            if (distancia <= 200) 
            {
                valorAPagar = distancia * 0.50;
                Console.WriteLine("\n " + nome + ", nesse caso como você vai rodar menos que 200km");
                Console.WriteLine(" você ira pagar um total de: R$" + valorAPagar + " por " + distancia + "km rodados");
            }
            else
            {
                valorAPagar = distancia * 0.45;
                Console.WriteLine("\n" + nome + " nesse caso como você vai rodar mais que 200km");
                Console.WriteLine("\n" + nome + " você ira pagar um total de: R$" + valorAPagar + " por " + distancia + "km rodados");
            }

            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");

            Console.ReadKey();
            */

            #endregion

            #region Exercicio 025

            /*
            Console.WriteLine("-*-*-*-*-* Programa de formar um triangulo *-*-*-*-*-\n");
            Console.WriteLine("Informe a primeira medida");
            double lado1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a segunda medida");
            double lado2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a terceira medida");
            double lado3 = double.Parse(Console.ReadLine());

            if ((lado1 + lado2 < lado3) || (lado2 + lado3 < lado1) || (lado3 + lado1 < lado2)) 
            {
                Console.WriteLine("Essas 3 retas NÃO formam um triangulo");
            }
            else
            {
                Console.WriteLine("Essas 3 retas formam um triangulo");
            }
            Console.WriteLine();
            Console.WriteLine("-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            
            Console.ReadKey();
            */

            #endregion

            #region Exercicio 026

            /*
            Inicio:
            Console.WriteLine("-*-*-*-*-* Programa de Comparação de valores *-*-*-*-*-\n");
            Console.WriteLine("Informe um primeiro número");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe um segundo número");
            double num2 = double.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("O primeiro valor é o maior");
            }
            else if (num1 < num2)
            {
                Console.WriteLine("O segundo valor é o maior");
            }
            else
            {
                Console.WriteLine("Não existe valor maior, os dois são iguais");
            }

            Console.WriteLine();
            Console.WriteLine("-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");


            Console.ReadKey();
            goto Inicio;
            */

            #endregion

            #region Exercicio 027

            /*
            Console.WriteLine("-*-*-*-*-* Programa de Poder de voto *-*-*-*-*-\n");
            Console.Write(" Qual seu nome? ");
            string nome = Console.ReadLine();
            Console.Write("\n" + nome + " Qual foi a sua primeira nota? ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("\n" + nome + " Qual foi a sua segunda nota? ");
            double n2 = double.Parse(Console.ReadLine());

            double media = (n1 + n2) / 2;

            if (media <= 4.9 ) 
            {
                Console.WriteLine("\n" + nome + " Você foi reprovado");
            }
            else if (media <= 6.9)
            {
                Console.WriteLine("\n" + nome + " Você esta em recuperação");
            }
            else
            {
                Console.WriteLine("\n" + nome + " Você esta aprovado");
            }

            Console.WriteLine();
            Console.WriteLine("-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();
            */

            #endregion

            #region Exercicio 028

            /*
             Console.WriteLine("-*-*-*-*-* Programa de formar um triangulo *-*-*-*-*-\n");
             Console.Write(" Informe a largura do terreno em metros: ");
             double largura = double.Parse(Console.ReadLine());
             Console.Write("\n Informe a comprimento do terreno em metros: ");
             double comprimento = double.Parse(Console.ReadLine());
             double m2 = largura * comprimento;
             Console.WriteLine("\n Esse terreno tem: " + m2 + "m²");

             if (m2 < 100) 
             {
                 Console.WriteLine("\n Esse terreno é POPULAR");
             }
             else if(m2 < 500)
             {
                 Console.WriteLine("\n Esse terreno é MASTER");
             }
             else
             {
                 Console.WriteLine("Esse terreno é VIP");
             }

             Console.WriteLine();
             Console.WriteLine("-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");

             Console.ReadKey();
             */

            #endregion

            #region Exercicio 029

            /*
            Inicio:
            Console.WriteLine("-*-*-*-*-* Programa de Poder de voto *-*-*-*-*-\n");
            Console.Write(" Favor informe seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("\n Favor informe quanto tempo você trabalha na empresa: ");
            int tempoDeEmpresa = int.Parse(Console.ReadLine());
            Console.Write("\n Favor informe seu salário: ");
            double salario = double.Parse(Console.ReadLine());
            double valorDeAumento = 0;

            if (tempoDeEmpresa <= 3)
            {
                valorDeAumento = (salario * 3) / 100;
                Console.WriteLine("\n Olá " + nome + " por você ter " + tempoDeEmpresa + " anos de empresa, você vai receber um aumento de 3%");
                Console.WriteLine(" que equivale um valor de R$" + valorDeAumento + " você vai receber um novo salario de: R$" + (salario + valorDeAumento));

            }
            else if (tempoDeEmpresa <= 10)
            {
                valorDeAumento = (salario * 12.5) / 100;
                Console.WriteLine("\n Olá " + nome + " por você ter " + tempoDeEmpresa + " anos de empresa, você vai receber um aumento de 12,5%");
                Console.WriteLine(" que equivale um valor de R$" + valorDeAumento + " você vai receber um novo salario de: R$" + (salario + valorDeAumento));
            }
            else
            {
                valorDeAumento = (salario * 20) / 100;
                Console.WriteLine("\n Olá " + nome + " por você ter " + tempoDeEmpresa + " anos de empresa, você vai receber um aumento de 20%");
                Console.WriteLine(" que equivale um valor de R$" + valorDeAumento + " você vai receber um novo salario de: R$" + (salario + valorDeAumento));
            }


            Console.WriteLine();
            Console.WriteLine("-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");


            Console.ReadKey();
            goto Inicio;
            */

            #endregion

            #region Exercicio 030

            /*
            Console.WriteLine("-*-*-*-*-* Programa de formar um triangulo *-*-*-*-*-\n");
            Console.WriteLine("Informe a primeira medida");
            double lado1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a segunda medida");
            double lado2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a terceira medida");
            double lado3 = double.Parse(Console.ReadLine());


            if ((lado1 + lado2 <= lado3) || (lado2 + lado3 <= lado1) || (lado3 + lado1 <= lado2))
            {
                if ((lado1 == lado2) && (lado2 == lado3))
                {
                    Console.WriteLine("Triangulo EQUILÁTERO ");
                }
                else if ((lado1 == lado2) && (lado2 != lado3))
                {
                    Console.WriteLine("Triangulo ISÓSCELES ");
                }
                else if((lado1 != lado2) && (lado2 != lado3) && (lado1 != lado3))
                {
                    Console.WriteLine("Triangulo ESCALENO ");
                }
            }
            else
            {
                Console.WriteLine("Essas 3 retas NÃO formam um triangulo");
            }
                       
            Console.WriteLine();
            Console.WriteLine("-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");

            Console.ReadKey();
            */

            #endregion

            #region Exercicio 031 (MELHORADO)

            /*
            Console.WriteLine("-*-*-*-*-* JoKenPo *-*-*-*-*-\n");
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Inicio:
            Console.Write("\n Olá " + nome + " seja bem vindo ao Jogo de JoKenPo \n");
            Console.Write("\n Escolha um entre \"pedra\" , \"papel\" ou \"tesoura\" \n");
            string escolhaDoUsuario = Console.ReadLine();
            
            string[] escolhaDoPrograma = { "pedra", "papel", "tesoura" };
            Random numAleatorio = new Random();
            string resultadoEscolhaPrograma = escolhaDoPrograma[numAleatorio.Next(0, 3)];


            Console.WriteLine(" A escolha do Programa foi: " + resultadoEscolhaPrograma + "\n");


            if ((escolhaDoUsuario == "pedra") && (resultadoEscolhaPrograma == "tesoura"))
            {
                Console.WriteLine(" Você ganhou, pedrea quebra a tesoura!");
            }
            else if ((escolhaDoUsuario == "pedra") && (resultadoEscolhaPrograma == "papel")) 
            {
                Console.WriteLine(" Você perdeu, papel embrulha a pedra!");
            }          
            else if ((escolhaDoUsuario == "papel") && (resultadoEscolhaPrograma == "pedra"))
            {
                Console.WriteLine(" Você ganhou, papel embrulha a pedra!!");
            }
            else if ((escolhaDoUsuario == "papel") && (resultadoEscolhaPrograma == "tesoura"))
            {
                Console.WriteLine(" Você perdeu, tesoura corta o papel!");
            }
            else if ((escolhaDoUsuario == "tesoura") && (resultadoEscolhaPrograma == "papel"))
            {
                Console.WriteLine(" Você ganhou, tesoura corta o papel!");
            }
            else if ((escolhaDoUsuario == "tesoura") && (resultadoEscolhaPrograma == "pedra"))
            {
                Console.WriteLine(" Você perdeu, pedrea quebra a tesoura!");
            }
            else if ((escolhaDoUsuario == resultadoEscolhaPrograma))
            {
                Console.WriteLine(" Deu empate! ");
            }
        Escolha:
            Console.WriteLine("\n Quer continuar a jogar? se sim aperte \"s\" se não aperte \"n\" e depois ENTER ! ");
            string op = Console.ReadLine();
            switch (op)
            {
                default:
                    Console.WriteLine("Opção invalida \n");
                    goto Escolha;
                case "s":
                    goto Inicio;
                    break;
                case "n":
                    goto Final;
                    break;
            }

            Final:
            Console.WriteLine("-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");


            Console.ReadKey();
            */

            #endregion

            #region Exercicio 032

            /*
            Console.WriteLine("-*-*-*-*-* Programa adivinhe qual é o numero sorteado *-*-*-*-*-\n");
            Inicio:
            Console.Write(" Olá escolha um numero entre 1 e 5: ");
            int num = int.Parse(Console.ReadLine());
            
            Random numAleatorio = new Random();
            int numSorteado = numAleatorio.Next(1, 5);

            
            if (num == numSorteado)
            {
                Console.WriteLine("\n O número que o computador escolheu foi: " + numSorteado);
                Console.WriteLine("\n Parabens você acertou o numero que o computador escolheu! ");
                Escolha1:
                Console.WriteLine("\n Quer tentar novamente? se sim aperte \"s\" se não aperte \"n\" e depois ENTER ! ");
                string op = Console.ReadLine();
                switch (op)
                {
                    default:
                        Console.WriteLine("\n Opção invalida \n");
                        goto Escolha1;
                    case "s":
                        goto Inicio;
                    case "n":
                        goto Final;
                }
            }
            else if (num > 5)
            {
                Console.WriteLine("\n Você não escolheu um número entre 1 e 5! \n");
                goto Inicio;
            }
            else if (num != numSorteado)
            {
                Console.WriteLine("\n O número que o computador escolheu foi: " + numSorteado);
                Console.WriteLine("\n Eita você não acertou o número ");
                Escolha2:
                Console.WriteLine("\n Quer tentar novamente? se sim aperte \"s\" se não aperte \"n\" e depois ENTER ! ");
                string op = Console.ReadLine();
                switch (op)
                {
                    default:
                        Console.WriteLine("\n Opção invalida \n");
                        goto Escolha2;
                    case "s":
                        goto Inicio;
                    case "n":
                        goto Final;
                }
            }
            Final:
            Console.WriteLine();
            Console.WriteLine("-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();
            */

            #endregion

            #region Exercicio 033

            /*
            Console.WriteLine("-*-*-*-*-* Programa de Emprestimo *-*-*-*-*-\n");
            Console.WriteLine(" QUal seu nome? ");
            string nome = Console.ReadLine();
            Console.WriteLine("\n Olá " + nome + ", seja bem vindo!");
            Console.WriteLine("\n informe o valor da casa e pressione ENTER");
            double valorCasa = double.Parse(Console.ReadLine());
            Console.WriteLine("\n informe o valor do seu salario e pressione ENTER");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("\n informe em quantos anos você vai querer pagar? e pressione ENTER ");
            Console.WriteLine(" Obs.: tem que ser acima de 1 ano.");


            int tempoAPagar = int.Parse(Console.ReadLine()) * 12;
            double parcelaAPagar = valorCasa / tempoAPagar ;
            double percentSalario = salario * (parcelaAPagar /10000);
            double percentCorres = (percentSalario * 100) / salario;


            if (parcelaAPagar > (salario * 0.3))
            {
                Console.WriteLine(" Desculpe sua renda atual não permite que você compre uma casa nesse valor e dividindo em " + tempoAPagar + " meses.");
                Console.WriteLine(" O valor da parcela, não pode ultrapassar 30% do seu salario e atualmente o valor da parcela e de " + (percentCorres, 2)+ "%");
                Console.WriteLine(" Tente comprar uma casa no valor menor ou aumentar o prazo de pagamento");
            }
            else
            {
                Console.WriteLine(" Emprestimo aprovado você pagara R$" + parcelaAPagar + " em " + tempoAPagar + " meses.");
            }
            Console.WriteLine();
            Console.WriteLine("-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");


            Console.ReadKey();
            */

            #endregion

            #region Exercicio 034

            /*
            float peso, altura, imc;
            
            Console.WriteLine("-*-*-*-*-* Programa Calculo de IMC *-*-*-*-*-\n");
            Console.WriteLine();
            Console.WriteLine("Informe seu peso em quilogramas e pressione enter ");
            Console.WriteLine("Ex.: 80,4");
            peso = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Informe sua altura em metros e pressione enter ");
            Console.WriteLine("Ex.: 1,65");
            altura = float.Parse(Console.ReadLine());

            //logica

            imc = peso / (altura * altura);
            Console.WriteLine("Seu IMC é: " + imc);

            if (imc < 16.9)
            {
                Console.WriteLine("Muito abaixo do peso");
            }
            else if (imc < 18.4)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc < 24.9)
            {
                Console.WriteLine("Peso normal");
            }
            else if (imc < 29.9)
            {
                Console.WriteLine("Acima do peso");
            }
            else if (imc < 34.9)
            {
                Console.WriteLine("Obesidade grau I");
            }
            else if (imc < 40)
            {
                Console.WriteLine("Obesidade grau II");
            }
            else
            {
                Console.WriteLine("Obesidade grau III");
            }
            Console.WriteLine();
            Console.WriteLine("-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");


            Console.ReadKey();
            */

            #endregion

            #region Exercicio 016


            /*
                - Carros populares (aluguel de R$90 por dia)
                - Até 100Km percorridos: R$0,20 por Km
                - Acima de 100Km percorridos: R$0,10 por Km
              
                - Carros de luxo (aluguel de R$150 por dia)
                - Até 200Km percorridos: R$0,30 por Km
                - Acima de 200Km percorridos: R$0,25 por Km
            
            */

            Console.WriteLine("-*-*-*-*-* Programa de Poder de voto *-*-*-*-*-\n");
            Console.Write("\n Informe seu nome: ");
            string nome = Console.ReadLine();
            Inicio:
            Console.Write("\n Olá " + nome + ", favor informe o tipo de carro alugado popular ou luxo: ");
            string tipoCarro = Console.ReadLine();
            if ((tipoCarro != "popular") && (tipoCarro != "luxo"))
            {
                Console.Write("\n ATENÇÂO!!! Favor informe um tipo de carro valido!\n");
                goto Inicio;
            }
            else
            {
                goto Passo2;
            }
            Passo2:
            Console.Write("\n informe a quantidade de diarias: ");
            double diarias = double.Parse(Console.ReadLine());
            Console.Write("\n informe a quantidade de quilometros rodados: ");
            double kmRodados = double.Parse(Console.ReadLine());
            double valorDiaria = 0;
            double valorKmRodados = 0;
            double valorTotal = 0;

            if ( tipoCarro == "popular" )
            {
                valorDiaria = diarias * 90;
                if (kmRodados > 100 )
                {
                    valorKmRodados = kmRodados * 0.10;
                }
                else
                {
                    valorKmRodados = kmRodados * 0.20;
                }
                valorTotal = valorDiaria + valorKmRodados;
                Console.WriteLine();
                Console.Write(" " + nome + " você pagará um valor de: R$" + valorDiaria + " por diaria e um valor de: R$" + (valorKmRodados / kmRodados) + " por km rodado");
                Console.Write(" valor total de: R$" + valorKmRodados + " por " + kmRodados + "km rodados");
                Console.Write(" valor total dos serviços de: R$" + valorTotal);
            }
            else if ( tipoCarro == "luxo")
            {
                valorDiaria = diarias * 150;
                if (kmRodados > 200)
                {
                    valorKmRodados = kmRodados * 0.25;
                }
                else
                {
                    valorKmRodados = kmRodados * 0.30;
                }
                valorTotal = valorDiaria + valorKmRodados;
                Console.WriteLine();
                Console.WriteLine(" " + nome + " você pagará um valor de: R$" + valorDiaria + " por diaria e um valor de: R$" + (valorKmRodados / kmRodados) + " por km rodado");
                Console.WriteLine(" valor total de: R$" + valorKmRodados + " por " + kmRodados + "km rodados");
                Console.WriteLine(" valor total dos serviços de: R$" + valorTotal);
            }
            else
            {
                Console.WriteLine(" \n ATENÇÂO!!! Você digitou um tipo de veiculo invalido. \n");
                goto Inicio;
            }
            Console.WriteLine();
            Console.WriteLine("-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");


            Console.ReadKey();


            #endregion



        }
    }
}
