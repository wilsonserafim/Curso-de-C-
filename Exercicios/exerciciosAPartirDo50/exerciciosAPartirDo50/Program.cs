using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace exerciciosAPartirDo50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercicio 050 (refeito)

            /*
            Console.WriteLine("-*-*-*-*-* Programa *-*-*-*-*-\n");
            Random numAletorio = new Random();
            int numAcimade5 = 0;
            int numDivPor3 = 0;


            Console.Write("Quais foram os números sorteados? R- ");
            for (int i = 0; i <= 20; i++)
            {
                int num = numAletorio.Next(0, 10);
                if (num > 5 )  
                {
                    numAcimade5++;
                    if (num % 3 == 0)
                    {
                        numDivPor3++;
                    }
                }
                else if ((num < 5) && (num % 3 == 0) && (num != 0)) 
                {
                    numDivPor3++;
                }
                Console.Write(" " + num + ",");
            }
            Console.WriteLine();
            Console.WriteLine("Quantos números estão acima de 5? R- " + numAcimade5);
            Console.WriteLine("Quantos números são divisíveis por 3 ? R-  " + numDivPor3);
            
            Console.WriteLine();
            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadLine();
            */

            #endregion

            #region Exercicio 051

            /*
            Console.WriteLine("-*-*-*-*-* Programa  *-*-*-*-*-\n");
            int i = 0;
            float maisBarato = 9999999;
            float maisCaro = 0;

            for (i = 0; i <= 7; i++)
            {
                Console.WriteLine(" Favor insira o preço do produto " + (i+1));
                float preço = float.Parse(Console.ReadLine());
                if (maisCaro <= preço)
                {
                    maisCaro = preço;
                }    
                else if (maisBarato >= preço)
                {
                    maisBarato = preço;
                }
            }

            Console.WriteLine("o produto mais caro custa: " + maisCaro);
            Console.WriteLine("o produto mais barato custa: " + maisBarato);
            
            Console.WriteLine();
            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");

            Console.ReadKey();
            */

            #endregion

            #region Exercicio 052

            /*
            Console.WriteLine("-*-*-*-*-* Programa *-*-*-*-*-\n");
            int i = 0;
            int maiorIdade = 18;
            int menorIdade = 5;
            int mediaidade = 0;
            int contMaiorIdade = 0;
            int contMenorIdade = 0;

            for (i = 0; i <= 9; i++)
            {
                Console.Write(" Favor insira a idade da pessoa: " + (i+1) + ": ");
                int idade = int.Parse(Console.ReadLine());
                mediaidade += idade;
                if (maiorIdade <= idade)
                {
                    contMaiorIdade = contMaiorIdade + 1;
                    maiorIdade = idade;

                }    
                else if (menorIdade >= idade)
                {
                    contMenorIdade = contMenorIdade + 1;
                }

            }

            Console.WriteLine(" a media da idade é: " + (mediaidade / 8) + " anos");
            Console.WriteLine(" " + contMaiorIdade + " pessoas tem mais de 18 anos");
            Console.WriteLine(" " + contMenorIdade + " pessoas tem menos de 5 anos");
            Console.WriteLine(" A pessoa com idade mais velha tem " + maiorIdade + " anos");


            Console.WriteLine();
            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");

            Console.ReadKey();
            */

            #endregion

            #region Exercicio 053

            /*
            Console.WriteLine("-*-*-*-*-* Programa media idade *-*-*-*-*-\n");
            int i = 0;
            int homemCad = 0;
            int mulherCad = 0;
            int mediaIdadeGrupo = 0;
            int mediaIdadeMasculina = 0;
            int mulherAcimade20 = 0;

            for (i = 0; i <= 4; i++)
            {
                Console.Write(" Favor insira a idade da pessoa: " + ( i + 1) + ": ");
                int idade = int.Parse(Console.ReadLine());
                Console.Write(" Favor insira a sexo da pessoa: " + (i + 1) + " masculino ou feminino : ");
                string sexo = (Console.ReadLine());
                mediaIdadeGrupo += idade;
                if (sexo == "masculino")
                {
                    homemCad = homemCad + 1;
                    mediaIdadeMasculina += idade;
                    mediaIdadeGrupo += idade;

                }    
                else if ((sexo == "feminino") && (idade >= 20))
                {
                    mulherCad = mulherCad + 1;
                    mulherAcimade20 = mulherAcimade20 + 1;
                    mediaIdadeGrupo += idade;

                }
                else if (sexo == "feminino")
                {
                    mulherCad = mulherCad + 1;
                    mediaIdadeGrupo += idade;

                }

            }

            Console.WriteLine("Foram cadastrados: " + homemCad + " homens");
            Console.WriteLine("Foram cadastradas: " + mulherCad + " mulheres" );
            Console.WriteLine("A média de idade do grupo é: " + (mediaIdadeGrupo / 5) + " anos");
            Console.WriteLine("A média de idade dos homens é: " + (mediaIdadeMasculina / homemCad) + " anos");
            Console.WriteLine("Temos: " + mulherAcimade20 + " mulheres acima de 20 anos");


            Console.WriteLine();
            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");

            Console.ReadKey();
            */

            #endregion

            #region Exercicio 054 (refeito)

            Console.WriteLine("-*-*-*-*-* Programa  media peso e altura *-*-*-*-*-\n");
            float mediaAltura = 0;
            float pessoasMais90kg = 0;
            float pessoasMenos50kgE160Ctm = 0;
            float pessoasMais190CtmEMais100Kg = 0;

            for (int i = 0; i <= 7; i++)
            {
                Console.Write(" Favor insira o peso da pessoa: " + (i + 1) + ": ");
                float peso = float.Parse(Console.ReadLine());
                Console.Write(" Favor insira a altura da pessoa: " + (i + 1) + " em metros ex.:1,60 ou 1,80 : ");
                float altura = float.Parse(Console.ReadLine());
                mediaAltura += altura;//a
                if (peso >= 90)
                {
                    pessoasMais90kg++;//b
                    if ((peso >= 100) && (altura >= 1.9))
                    {
                        pessoasMais190CtmEMais100Kg++;//d
                    }
                }
                else if ((peso <= 50) && (altura <= 1.6))
                {
                    pessoasMenos50kgE160Ctm++;
                }


            }
            Console.WriteLine();
            Console.WriteLine("A média de altura foi: " + (mediaAltura / 7));//a
            Console.WriteLine();
            Console.WriteLine(pessoasMais90kg + " pessoas pesam mais que 90k");//b
            Console.WriteLine();
            Console.WriteLine(pessoasMenos50kgE160Ctm + " pessoas medem menos que 1.60m e tem menos que 50k");
            Console.WriteLine();
            Console.WriteLine(pessoasMais190CtmEMais100Kg + " pessoas medem mais que 1.90m e tem mais que 90k");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");

            Console.ReadLine();


            #endregion

            #region Exercicio 055 - (032)

            /*
            Console.WriteLine("-*-*-*-*-* Programa adivinhe qual é o numero sorteado *-*-*-*-*-\n");
            Inicio:
            Random numAleatorio = new Random();
            int numSorteado = numAleatorio.Next(1, 10);
            int i = 1;

            Console.Write(" \n Olá você terá 4 chances de acertar o número, escolha um numero entre 1 e 10: ");
            Console.Write(" \n chance1: ");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 == numSorteado)
            {
                Console.WriteLine("\n Parabens você acertou o número que o computador escolheu!\n ");
                Console.WriteLine("\n O número que o computador escolheu foi: " + numSorteado +"\n" );
                goto Escolha2;
            }
            else
            {
                Console.WriteLine("\n Eita você não acertou o número, tente mais uma vez\n ");
                for (i = 1; i < 4; i++)
                {
                    Console.Write(" \n chance" + (i + 1) + ": ");
                    int num = int.Parse(Console.ReadLine());
                    if (num == numSorteado)
                    {
                        Console.WriteLine("\n Parabens você acertou o numero que o computador escolheu!\n ");
                        Console.WriteLine("\n O número que o computador escolheu foi: " + numSorteado + "\n");
                        goto Escolha2;
                    }
                    else if (num > 10)
                    {
                        Console.WriteLine("\n Você não escolheu um número entre 1 e 10! \n");
                    }
                    else if (num != numSorteado)
                    {
                        Console.WriteLine("\n Eita você não acertou o número, tente mais uma vez\n ");
                    }
                }
            
            }
            Console.WriteLine("\n O número que o computador escolheu foi: " + numSorteado);
            Escolha2:
            Console.WriteLine("\n Quer jogar novamente? se sim aperte \"s\" se não aperte \"n\" e depois ENTER ! ");
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
            Final:
            Console.WriteLine("\n O número que o computador escolheu foi: " + numSorteado);
            Console.WriteLine();
            Console.WriteLine("-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();
            */

            #endregion

            #region Exercicio 056

            /*
            Console.WriteLine("-*-*-*-*-* Programa *-*-*-*-*-\n");
            Console.WriteLine("informe até 20 numeros a serem somados \n ");
            double somatorio = 0;
            
            int i = 0;

            for (i = 0; i < 20; i++)
            {
                Console.Write("\n Informe o número na posição: " + (i + 1) + ": ");
                double somatorio2 = double.Parse(Console.ReadLine());
                
                if (somatorio2 != 1111)
                {
                    somatorio += somatorio2;
                    
                }
                else if (somatorio2 == 1111)
                {
                    somatorio += somatorio2;
                    Console.WriteLine("\n Chegamos no numero chave não podemos continuar a partir daqui \n");
                    goto Final;
                }
            }
            Final:
            Console.WriteLine("\n resultado da soma: " + somatorio);
            Console.WriteLine();
            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();
            */

            #endregion

            #region Exercicio 057

            /*
            Console.WriteLine("-*-*-*-*-* Programa  *-*-*-*-*-\n");
            float salarioHomens = 0;
            float salarioMulheres = 0;
            Inicio:
            Console.WriteLine("informe o sexo do funcionario: ");
            string sexo = Console.ReadLine();
            Console.WriteLine("informe o salario do funcionario: ");
            float salario = float.Parse(Console.ReadLine());
            
            if ((sexo == "masculino") || (sexo == "Masculino"))
            {
                salarioHomens += salario;
            }
            else if ((sexo == "feminino") || (sexo == "Feminino"))
            {
                salarioMulheres += salario;
            }
            Escolha:
            Console.WriteLine("\n Quer continuar a inserir os dados? se sim aperte \"s\" se não aperte \"n\" e depois ENTER ! ");
            string op = Console.ReadLine();
            switch (op)
            {
                default:
                    Console.WriteLine("Opção invalida \n");
                    goto Escolha;
                case "s":
                    goto Inicio;
                case "n":
                    goto Final;
            }
            Final:
            Console.WriteLine(" A soma dos salarios recebidos pelos homens é : " + salarioHomens);
            Console.WriteLine(" A soma dos salarios recebidos pelas mulheres é : " + salarioMulheres);

            Console.WriteLine();
            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();
            */

            #endregion

            #region Exercicio 058


            /*
            Console.WriteLine("-*-*-*-*-* Programa  *-*-*-*-*-\n");
            Console.WriteLine("informe idade dos alunos: \n ");
            double somatorio = 0;

            for (int i = 0; i < 9999999; i++)
            {
                Console.Write("\n informe idade dos aluno(a): " + (i + 1) + ": ");
                double somatorio2 = double.Parse(Console.ReadLine());
                
                if (somatorio2 != 999)
                {
                    somatorio += somatorio2;
                    
                }
                else if (somatorio2 == 999)
                {
                    somatorio += somatorio2;
                    Console.WriteLine("\n Chegamos na idade chave não podemos continuar a partir daqui \n");
                    goto Final;
                }
            }
            Final:
            Console.WriteLine("\n foram cadastrados: " + (i + 1) + " alunos");
            Console.WriteLine("\n a média das idades é: " + (somatorio / i));
            Console.WriteLine();
            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();
            */

            #endregion

            #region Exercicio 059


            /*
            Console.WriteLine("-*-*-*-*-* Programa  *-*-*-*-*-\n");
            int maiorIdade = 0;
            int cadHomens = 0;
            int mulherMaisJovem = 0;
            int mediaIdadeHomens = 0;
            int cont = 0;
            
            Inicio:

            Console.Write("informe o sexo da pessoa: ");
            string sexo = Console.ReadLine();
            Console.Write("informe a idade dessa mesma pessoa: ");
            int idade = int.Parse(Console.ReadLine());
            
            if (idade >= maiorIdade ) 
            {
                if ((sexo == "masculino") || (sexo == "Masculino"))
            {
                    cadHomens = (cadHomens + 1);
                    mediaIdadeHomens += idade;
                    maiorIdade = idade;
                    cont = cont + 1;
                    Console.WriteLine(cont + " \n");
                }
                else if ((sexo == "feminino") || (sexo == "Feminino"))
                {
                    mulherMaisJovem = idade;
                    maiorIdade = idade;
                }
            }
            else if (idade <= maiorIdade)
            {
                if ((sexo == "masculino") || (sexo == "Masculino"))
                {
                    cadHomens = (cadHomens + 1);
                    mediaIdadeHomens += idade;
                    cont = cont + 1;
                    Console.WriteLine(cont + " \n");
                }
                else if ((sexo == "feminino") || (sexo == "Feminino"))
                {
                    mulherMaisJovem = idade;
                }
            }


            Escolha:
            Console.Write("\n Quer continuar a inserir os dados? se sim aperte \"s\" se não aperte \"n\" e depois ENTER ! ");
            string op = Console.ReadLine();
            switch (op)
            {
                default:
                    Console.WriteLine("\nOpção invalida \n");
                    goto Escolha;
                case "s":
                    goto Inicio;
                case "n":
                    goto Final;
            }
            Final:
            Console.WriteLine("\n qual é a maior idade lida? R-" + maiorIdade);
            Console.WriteLine("\n quantos homens foram cadastrados? R-" + cadHomens);
            Console.WriteLine("\n qual é a idade da mulher mais jovem? R-" + mulherMaisJovem);
            Console.WriteLine("\n qual é a média de idade entre os homens? R-" + (mediaIdadeHomens / cont));

            Console.WriteLine();
            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();
            */

            #endregion

            #region Exercicio 060


            /*
            Console.WriteLine("-*-*-*-*-* Programa *-*-*-*-*-\n");
            string nomeMaisVelha = "";
            string mulherMaisJovem = "";
            int mediaIdadeGrupo = 0;
            int homensMais30 = 0;
            int mulheresMenos18 = 0;
            int menorIdadeMulher = 99999;
            int maiorIdade = 0;
            int cont = 0;

        Inicio:

            Console.Write("informe o nome da pessoa: ");
            string nome = Console.ReadLine();
            Console.Write("informe o sexo de: " + nome + " masculino ou feminino: ");
            string sexo = Console.ReadLine();
            Console.Write("informe a idade de: " + nome + ": ");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= maiorIdade)
            {
                nomeMaisVelha = nome;
                maiorIdade = idade;
                mediaIdadeGrupo += idade;
                cont++;

                if ((sexo == "masculino") && (idade >= 30))
                {
                    homensMais30 = (homensMais30 + 1);
                }
                else if ((sexo == "feminino") && (idade <= 18))
                {
                    mulheresMenos18 = (mulheresMenos18 + 1);
                    if (idade <= menorIdadeMulher)
                    {
                        menorIdadeMulher = idade;
                    }
                }
                else if (idade <= menorIdadeMulher)
                {
                    menorIdadeMulher = idade;
                }

            }
            else if (idade <= maiorIdade)
            {
                mediaIdadeGrupo += idade;
                cont++;
                if ((sexo == "masculino") && (idade >= 30))
                {
                    homensMais30++;
                }
                else if ((sexo == "feminino") && (idade <= 18))
                {
                    mulheresMenos18++;
                    if (idade <= menorIdadeMulher)
                    {
                        menorIdadeMulher = idade;
                    }
                }
                else if (idade <= menorIdadeMulher)
                {
                    menorIdadeMulher = idade;

                }

            }
        Escolha:
            Console.Write("\n Quer continuar a inserir os dados? se sim aperte \"s\" se não aperte \"n\" e depois ENTER ! ");
            string op = Console.ReadLine();
            switch (op)
            {
                default:
                    Console.WriteLine("\nOpção invalida \n");
                    goto Escolha;
                case "s":
                    goto Inicio;
                case "n":
                    goto Final;
            }
        Final:
            Console.WriteLine("\n O nome da pessoa mais velha? R-" + nomeMaisVelha);
            Console.WriteLine("\n O nome da mulher mais jovem? R-" + mulherMaisJovem);
            Console.WriteLine("\n A média de idade do grupo? R-" + (mediaIdadeGrupo / cont));
            Console.WriteLine("\n Quantos homens tem mais de 30 anos? R-" + homensMais30);
            Console.WriteLine("\n Quantas mulheres tem menos de 18 anos? R-" + mulheresMenos18);

            Console.WriteLine();
            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();
            */

            #endregion

            #region Exercicio 061

            /*
            Console.WriteLine("-*-*-*-*-* Programa *-*-*-*-*-\n");
            int i = 0;

            for (i = 0; i < 30;)
            {
                Console.Write(" " + i + " ");

                i = i + 3;
                
                if (i == 30)
                {
                    Console.Write(" " + i + " ");
                    Console.WriteLine("Acabou!!!");
                }

            }
            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();


            #endregion

            #region Exercicio 062


            Console.WriteLine("-*-*-*-*-* Programa adivinhe qual é o numero sorteado *-*-*-*-*-\n");
            int i = 0;

            for (i = 0; i < 30;)
            {
                Console.Write(" " + i + " ");

                i = i + 3;

                if (i == 30)
                {
                    Console.Write(" " + i + " ");
                    Console.WriteLine("Acabou!!!");
                }

            }
            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();
            */

            #endregion

            #region Exercicio 062


            /*
            Console.WriteLine("-*-*-*-*-* Programa  *-*-*-*-*-\n");
            int mediaIdade = 0;
            int maisDe21Anos = 0;
            int cont = 0;

            Inicio:

            Console.Write("informe a idade da pessoa : ");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 21)
            {
                cont++;
                mediaIdade += idade;
                maisDe21Anos++;
            }
            else if (idade < 21)
            {
                cont++;
                mediaIdade += idade;
            }
            Escolha:
            Console.Write("\n Quer continuar a inserir os dados? se sim aperte \"s\" se não aperte \"n\" e depois ENTER ! ");
            string op = Console.ReadLine();
            switch (op)
            {
                default:
                    Console.WriteLine("\nOpção invalida \n");
                    goto Escolha;
                case "s":
                    goto Inicio;
                case "n":
                    goto Final;
            }
        Final:
            Console.WriteLine("\n Quantas idades foram digitadas? R-" + cont);
            Console.WriteLine("\n Qual é a média entre as idades digitadas? R-" + (mediaIdade / cont));
            Console.WriteLine("\n Quantas pessoas tem 21 anos ou mais? R-" + maisDe21Anos);


            Console.WriteLine();
            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();
            */

            #endregion

            #region Exercicio 063

            /*
            Console.WriteLine("-*-*-*-*-* Programa *-*-*-*-*-\n");
            int somatodos = 0;
            int menorValor = 99999999;
            int media = 0;
            int valorePares = 0;
            int cont = 0;

        Inicio:

            Console.Write(" \n informe um numero : ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write((cont + 1));

            if (numero % 2 == 0)
            {
                somatodos += numero;
                media += numero;
                cont++;
                valorePares++;
                if (numero <= menorValor)
                {
                    menorValor = numero;
                }
            }
            else
            {
                somatodos += numero;
                media += numero;
                cont++;
                if (numero <= menorValor)
                {
                    menorValor = numero;
                }
            }
        Escolha:
            Console.Write("\n Quer continuar a inserir os dados? se sim aperte \"s\" se não aperte \"n\" e depois ENTER ! ");
            string op = Console.ReadLine();
            switch (op)
            {
                default:
                    Console.WriteLine("\n Opção invalida \n");
                    goto Escolha;
                case "s":
                    goto Inicio;
                case "n":
                    goto Final;
            }
        Final:
            Console.WriteLine("\n O somatório entre todos os valores? R-" + somatodos);
            Console.WriteLine("\n Qual foi o menor valor digitado? R-" + menorValor);
            Console.WriteLine("\n A média entre todos os valores? R-" + (media / cont));
            Console.WriteLine("\n Quantos valores são pares? R-" + valorePares);

            Console.WriteLine();
            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();
            */
            #endregion

            #region Exercicio 064

            /*
            Console.WriteLine("-*-*-*-*-* Programa  *-*-*-*-*-\n");
            int i = 0; 
            while (i < 40)
            {
                
                Console.Write(" " + i + " ");
                i += 5;
                if (i == 40)
                {
                    Console.Write( i + " Acabou! \n ");
                }

            }
            

            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();
            */

            #endregion

            #region Exercicio 065

            /*
            Console.WriteLine("-*-*-*-*-* Programa *-*-*-*-*-\n");
             int i = 100;

             while (i > 0)
             {
                 Console.Write(" " + i + " ");
                 i -= 10;
                 if (i == 0)
                 {
                     Console.Write(" " + i + " ");
                     Console.WriteLine("Acabou!!!");
                 }

             }
             Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
             Console.ReadKey();
             */

            #endregion

            #region Exercicio 066
            /*            
            Console.WriteLine("-*-*-*-*-* Programa *-*-*-*-*-\n");
            Console.Write("informe um numero para fazermos a tabuada dele: ");
            int tabuada = int.Parse(Console.ReadLine());
            int i = 0;
            Console.WriteLine();

            while ( i <= 10)
             {
                 Console.WriteLine( tabuada + " X " + i + "= " + (tabuada * i));
                 i++;
             }
             Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
             Console.ReadKey();
             */

            #endregion

            #region Exercicio 067

            /*
            Console.WriteLine("-*-*-*-*-* Programa *-*-*-*-*-\n");
            Console.Write("informe um numero para fazermos a contagem dele: ");
            int cont = int.Parse(Console.ReadLine());
            int i = 0;
            Console.WriteLine();

            while (i < cont)
            {
                Console.Write(" " +  i + " ");
                i++;
                if (i == cont)
                {
                    Console.Write(" " + i + " ");
                    Console.Write(" FIM!!!  \n");

                }

            }
            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();
            */

            #endregion

            #region Exercicio 068

            /*
            Console.WriteLine("-*-*-*-*-* Programa *-*-*-*-*-\n");
            int i = 0;
            int homemMais100K = 0;
            int mulherCad = 0;
            float mediaPesoMulheres = 0;
            float maiorPesohomens = 0;

            for (i = 0; i <= 8; i++)
            {
                Console.Write(" Favor insira o peso da pessoa: " + (i + 1) + ": ");
                float peso = float.Parse(Console.ReadLine());
                Console.Write(" Favor insira a sexo da pessoa: " + (i + 1) + " masculino ou feminino : ");
                string sexo = (Console.ReadLine());
                
                if (sexo == "masculino")
                {
                    if (peso >= 100) 
                    {
                        homemMais100K++;
                        if (peso > maiorPesohomens)
                        {
                            maiorPesohomens = peso; 
                        }
                    }
                }
                else if (sexo == "feminino") 
                {
                    mulherCad++;
                    mediaPesoMulheres += peso;
                }
                

            }

            Console.WriteLine("\nQuantas mulheres foram cadastradas: " + mulherCad);
            Console.WriteLine("\nQuantos homens pesam mais de 100Kg :" + homemMais100K);
            Console.WriteLine("\nA média de peso entre as mulheres: " + (mediaPesoMulheres / mulherCad) );
            Console.WriteLine("\nO maior peso entre os homens: " + maiorPesohomens);
            
            Console.ReadLine();
            */

            #endregion

            #region Exercicio 069

            /*
            Console.WriteLine("-*-*-*-*-* Programa  *-*-*-*-*-\n");
            Console.WriteLine("Informe o numero 1º termo da PA");
            double termo = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o numero razão da PA");
            double razao = double.Parse(Console.ReadLine());
            double controle = 0;
            double i = 0;
            controle = termo;

            for (i = 0; i < 10;)
            {
                

                controle += razao;

                Console.Write(" " + controle + " ");
                
                i++;

                if (i == 10)
                {
                    Console.Write(" " + controle + " ");
                    Console.WriteLine("Acabou!!!");
                }
            }

                Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
             Console.ReadKey();
            */

            #endregion

            #region Exercicio 071

            /*
            Console.WriteLine("-*-*-*-*-* Programa  *-*-*-*-*-\n");
             int i = 0;

             for (i = 0; i < 30;)
             {
                 Console.Write(" " + i + " ");

                 i = i + 3;

                 if (i == 30)
                 {
                     Console.Write(" " + i + " ");
                     Console.WriteLine("Acabou!!!");
                 }

             }
             Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
             Console.ReadKey();
            */

            #endregion

            #region Exercicio 070

            /*
            Console.WriteLine("-*-*-*-*-* Programa *-*-*-*-*-\n");
            int fb1, fb2, fb3;
            fb1 = 1;
            fb2 = 1;
            fb3 = 1;

            for (int i = 0; i < 10;)
            {
                Console.Write(" " + fb1 + " ");
                fb3 = fb1 + fb2;
                fb1 = fb2;
                fb2 = fb3;
                i++;
            }

            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();
            */

            #endregion

            #region Exercicio 071

            /*
            Console.WriteLine("-*-*-*-*-* Programa  *-*-*-*-*-\n");
            int[] numeros = new int[8];
            int i = 0;

             for (i = 0; i <= 8;)
             {
                numeros[i] = 999;
                
                Console.WriteLine(numeros[i]);

                i++;

            }
             Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
             Console.ReadKey();
            */

            #endregion

            #region Exercicio 072

            /*
            Console.WriteLine("-*-*-*-*-* Programa  *-*-*-*-*-\n");
            int[] num = new int[10];
            int i = 0;
            int aux = 5;

            for (i = 0; i < 10;) 
            {
                num[i] = aux;
                aux += 5;
                Console.Write(" " + num[i] + " ");
                i++;
            }

            Console.WriteLine();
            Console.WriteLine("\n -*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();
            */

            #endregion

            #region Exercicio 073
            /*
            Console.WriteLine("-*-*-*-*-* Programa  *-*-*-*-*-\n");
            int[] num = new int[10];
            int i = 0;
            int aux = 9;

            for (i = 0; i <= 10;)
            {
                num[i] = aux;
                aux -= 1;
                Console.Write(" " + num[i] + " ");
                i++;
            }

            Console.WriteLine();
            Console.WriteLine("\n -*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();
            */

            #endregion

            #region Exercicio 074

            /*
             
            Console.WriteLine("-*-*-*-*-* Programa  *-*-*-*-*-\n");
            int[] num = new int[10];
            int i = 0;
            int aux1 = 5;

            for (i = 0; i < 10;)
            {
                if (aux1 == 5)
                {
                    num[i] = aux1;
                    aux1 = aux1 - 2;
                }
                else if (aux1 == 3) 
                {
                    num[i] = aux1;
                    aux1 = aux1 + 2;
                }
                Console.Write(" " + num[i] + " ");
                i++;
            }

            Console.WriteLine();
            Console.WriteLine("\n -*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();
            
             */

            #endregion

            #region Exercicio 075

            /*
            Console.WriteLine("-*-*-*-*-* Programa *-*-*-*-*-\n");
            int fb1, fb2, fb3;
            fb1 = 1;
            fb2 = 1;
            fb3 = 1;
            int[] fibo = new int[16];

            for (int i = 0; i < 16;)
            {
                fibo[i] = fb1;
                Console.Write(" " + fibo[i] + " ");
                fb3 = fb1 + fb2;
                fb1 = fb2;
                fb2 = fb3;
                i++;
            }
            Console.WriteLine();
            Console.WriteLine(fibo[0] + ", " + fibo[1] + ", " + fibo[2] + ", " + fibo[3] + ", " + fibo[4] + ", " + fibo[5] + ", " + fibo[6] + ", " + fibo[7] + ", " + fibo[8] + ", " + fibo[9] + ", " + fibo[10] + ", " + fibo[11] + ", " + fibo[12] + ", " + fibo[13] + ", " + fibo[14] + ", " + fibo[15] + ", ");

            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();
            */

            #endregion

            #region Exercicio 076

            /*
            Console.WriteLine("-*-*-*-*-* Programa  *-*-*-*-*-\n");
            int[] num = new int[7];
            int i = 0;
            
            for (i = 0; i < 7;)
            {
                Random numAleatorio = new Random();
                int aux = numAleatorio.Next(1, 10000);
                num[i] = aux;
                Console.WriteLine(" " + num[i] + " ");
                i++;
            }

            Console.WriteLine();
            Console.WriteLine("\n -*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();
            */

            #endregion

            #region Exercicio 077

            /*
            Console.WriteLine("-*-*-*-*-* Programa *-*-*-*-*-\n");
            string[] nomes = new string[7];
            

            for (int i = 0;i < 7;)
            {
                Console.Write("Favor insira o nome da pessoa: " + ( i + 1 ) + ": " );
                nomes[i] = Console.ReadLine();
                i++;
            }

            Console.Write("\n Favor insira o nome da 7ª pessoa:" + nomes[6]);
            Console.Write("\n Favor insira o nome da 6ª pessoa:" + nomes[5]);
            Console.Write("\n Favor insira o nome da 5ª pessoa:" + nomes[4]);
            Console.Write("\n Favor insira o nome da 4ª pessoa:" + nomes[3]);
            Console.Write("\n Favor insira o nome da 3ª pessoa:" + nomes[2]);
            Console.Write("\n Favor insira o nome da 2ª pessoa:" + nomes[1]);
            Console.Write("\n Favor insira o nome da 1ª pessoa:" + nomes[0]);

            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();
            */

            #endregion

            #region Exercicio 078

            /*
            Console.WriteLine("-*-*-*-*-* Programa  *-*-*-*-*-\n");
            int[] num = new int[15];
            int[] num2 = new int[15];   
            for (int i = 0; i < 15;)
            {
                Console.Write("Escreva um numero na posição " + i + ": ");
                num[i] = int.Parse(Console.ReadLine());
                if (num[i] % 10 == 0)
                {
                    num2[i] = i;
                }
                else
                i++;
            }

            for (int i = 0; i < 15;)
            {
                Console.Write(" " + num[i] + ", ");
                i++;
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < 15;)
            {
                Console.Write(" " + num2[i] + ", ");
                i++;
            }

            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();
            */

            #endregion

            #region Exercicio 079

            /*
            Console.WriteLine("-*-*-*-*-* Programa  *-*-*-*-*-\n");
            int[] num = new int[15]; 
            for (int i = 0; i < 15;)
            {
                Console.Write("informe o numero " + i + ": ");
                num[i] = int.Parse(Console.ReadLine());
                i++;
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < 15;)
            {
                Console.Write(" " + num[i] + ", ");
                i++;
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < 15;)
            {
                if (num[i] % 2 == 0)
                {
                    Console.WriteLine(" o numero na posição " + i + ", de numero " + num[i] + " é Par");
                }
                i++;
            }
            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();
            */
            #endregion

            #region Exercicio 080


            //Console.WriteLine("-*-*-*-*-* Programa *-*-*-*-*-\n");
            //int[] numeros = new int[30];
            //int vezesDoNumero = 0;

            //Random randNum = new Random();

            //for (int i = 0; i < numeros.Length;)
            //{

            //    int rand = randNum.Next(1, 15);
            //    numeros[i] = rand;
            //    i++;
            //}
            //Console.WriteLine("Favor digite um numero ente 1 e 15");
            //int num = int.Parse(Console.ReadLine());
            //int[] numGuard = new int[30];

            //for (int i = 0; i < numeros.Length;)
            //{
            //    if (numeros[i] == num)
            //    {
            //        numGuard[i] = i;
            //    }
            //    i++;
            //}

            ////
            //Console.WriteLine();
            //Console.WriteLine("\n O numero digitado foi encontrado nas chaves: ");
            //Console.WriteLine();
            //for (int i = 0; i < numeros.Length;)
            //{
            //    if (numGuard[i] != 0)
            //    {
            //        Console.Write(" " + numGuard[i] + ", ");
            //    }
            //    i++;
            //}

            ////
            //for (int i = 0; i < numeros.Length;)
            //{
            //    if (numGuard[i] != 0)
            //    {
            //        vezesDoNumero++;
            //    }
            //    i++;
            //}
            //Console.WriteLine();
            //Console.WriteLine(" \n O numero digitado foi repetido: " + vezesDoNumero + " vezes.");
            ////
            //Console.WriteLine();
            //Console.WriteLine(" \n os numeros sorteados foram: ");
            //for (int i = 0; i < numeros.Length;)
            //{
            //    Console.Write(" " + numeros[i] + ", ");
            //    i++;
            //}

            //Console.WriteLine();
            //Console.WriteLine(" \n -*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*- \n");
            //Console.ReadKey();


            #endregion

            #region Exercicio 081

            /*
            Console.WriteLine("-*-*-*-*-* Programa *-*-*-*-*-\n");
            int[] idades = new int[8];
            int idadeMedia = 0;
            int[] posicaoMais25 = new int[8];
            int maioridade = 0;
            int posicaoMaiorIdade = 0;

            for (int i = 0; i < idades.Length;)
            {
                Console.Write("Informe a idade da pessoa " + i + ": ");
                idades[i] = int.Parse(Console.ReadLine());
                idadeMedia += idades[i];
                if ((idades[i] > maioridade) && (idades[i] < 25)) 
                {
                    maioridade = idades[i];
                    posicaoMaiorIdade = i;
                }
                if ((idades[i] > maioridade) && (idades[i] > 25))
                {
                    maioridade = idades[i];
                    posicaoMaiorIdade = i;
                    posicaoMais25[i] = i;
                }
                i++;
            }

            Console.WriteLine("Qual é a média de idade das pessoas cadastradas: " + (idadeMedia / idades.Length));
            Console.WriteLine();
            Console.WriteLine("Em quais posições temos pessoas com mais de 25 anos: ");
            Console.WriteLine();
            for (int i = 0; i < idades.Length;)
            {
                if ( posicaoMais25[i] != 0)
                {
                    Console.Write(" " + posicaoMais25[i] + ", ");
                }
                i++;
            }
            Console.WriteLine();
            Console.WriteLine("Qual foi a maior idade digitada: " + maioridade);
            Console.WriteLine();
            Console.WriteLine("Em que posições digitamos a maior idade: " + posicaoMaiorIdade);
            Console.WriteLine();



            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();
            */

            #endregion

            #region Exercicio 082

            /*
            Console.WriteLine("-*-*-*-*-* Programa *-*-*-*-*-\n");
            int[] notas = new int[10];
            int notaMedia = 0;
            int alunosAcimaDaMedia = 0;
            int maiorNota = 0;
            int somaNotas = 0;

            for (int i = 0; i < 10;)
            {
                Console.Write("Informe a nota do aluno " + (i +1) + ": ");
                notas[i] = int.Parse(Console.ReadLine());
                notaMedia += notas[i];
                if (notas[i] > maiorNota)
                {
                    maiorNota = notas[i];
                }
                i++;
            }
            somaNotas = (notaMedia / 10);

            for (int i = 0; i < 10;)
            {
                if (notas[i] > somaNotas)
                {
                    alunosAcimaDaMedia++;
                }
                i++;
            }

            Console.WriteLine("Qual é a média da turma: " + somaNotas);
            Console.WriteLine();
            Console.WriteLine("Quantos alunos estão acima da média da turma: " + alunosAcimaDaMedia);
            Console.WriteLine();
            Console.WriteLine("Qual foi a maior nota digitada: " + maiorNota);
            Console.WriteLine();
            Console.Write("Em que posições a maior nota aparece: ");
            for (int i = 0; i < 10;)
            {
                if (maiorNota == notas[i])
                {
                    Console.Write(" " + ( i + 1 ) + ", ");
                }
                i++;
            }
            Console.WriteLine();



            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();
            */

            #endregion

            #region Exercicio 083

            /*
            Console.WriteLine("-*-*-*-*-* Programa  *-*-*-*-*-\n");
            int[] numeros = new int[30];
            

            Random randNum = new Random();

            for (int i = 0; i < numeros.Length;)
            {

                int rand = randNum.Next(0, 99);
                numeros[i] = rand;
                i++;
            }
            
            for (int i = 0; i < numeros.Length;)
            {
                Console.Write(" " + numeros[i] + ", ");
                i++;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            int[] newEstoque = numeros.OrderBy(i => i).ToArray();

            for (int i = 0; i < newEstoque.Length;)
            {
                Console.Write(" " + newEstoque[i] + ", ");
                i++;
            }


            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();
            */

            #endregion

            #region Exercicio 084

            /*
            Console.WriteLine("-*-*-*-*-* Programa  *-*-*-*-*-\n");
            int[] idade = new int[9];
            string[] nome = new string[9];

            for (int i = 0; i < idade.Length;)
            {
                Console.Write("Qual o nome da " + ( i + 1) + " pessoa: ");
                nome[i] = Console.ReadLine();
                Console.Write("Qual a idade da " + (i + 1) + " pessoa: ");
                idade[i] = int.Parse(Console.ReadLine());
                i++;
            }
            Console.WriteLine();
            Console.WriteLine("Os menores de 18 anos são: ");
            Console.WriteLine();

            for (int i = 0; i < idade.Length;)
            {
                if (idade[i] < 18)
                {
                    Console.WriteLine("a pessoa de numero: " + (i + 1) + " de nome: " + nome[i]);
                    Console.WriteLine("e essa mesma pessoa de numero: " + (i + 1) + " tem: " + idade[i] + " anos.");
                    Console.WriteLine();
                }
                i++;
            }
            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();
            */

            #endregion

            #region Exercicio 085

            /*
            Console.WriteLine("-*-*-*-*-* Programa  *-*-*-*-*-\n");
            string[] nome = new string[5];
            string[] sexo = new string[5];
            float[] salario = new float[5];


            for (int i = 0; i < nome.Length;)
            {
                Console.Write("Qual o nome da " + (i + 1) + " pessoa: ");
                nome[i] = Console.ReadLine();
                Console.Write("Qual sexo da " + (i + 1) + " pessoa, masculino ou feminino : ");
                sexo[i] = Console.ReadLine();
                Console.Write("Qual salario da " + (i + 1) + " pessoa: ");
                salario[i] = float.Parse(Console.ReadLine());
                i++;
            }
            Console.WriteLine();
            Console.WriteLine("As mulheres que ganham mais de R$5.000,00 são: ");
            Console.WriteLine();

            for (int i = 0; i < nome.Length;)
            {
                if ((salario[i] > 5000) && (sexo[i] == "feminino"))  
                {
                    Console.WriteLine("A mulher da posição: " + (i + 1) + " de nome: " + nome[i] + " que recebe: " + salario[i]);
                    Console.WriteLine();
                }
                i++;
            }
            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();
            */

            #endregion

            #region Exercicio 086

            /*
            Console.WriteLine("-*-*-*-*-* Programa  *-*-*-*-*-\n");
            Procedimentos gerador = new Procedimentos();
            gerador.Gerador1();

            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();
            */

            #endregion

            #region Exercicio 087

            /*
            Console.WriteLine("-*-*-*-*-* Programa  *-*-*-*-*-\n");
            Procedimentos gerador = new Procedimentos();
            gerador.Gerador2("Aprendendo C# ( CSharp )");

            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();
            */

            #endregion

            #region Exercicio 088
            /*
            Console.WriteLine("-*-*-*-*-* Programa  *-*-*-*-*-\n");
            Procedimentos gerador = new Procedimentos();
            gerador.Gerador3("Aprendendo C# ( CSharp )", 4 );

            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();
            */
            #endregion

            #region Exercicio 089

            /*
            Console.WriteLine("-*-*-*-*-* Programa  *-*-*-*-*-\n");
            Procedimentos gerador = new Procedimentos();
            gerador.Gerador4("Aprendendo C# ( CSharp )", 3, 2);

            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();
            */

            #endregion

            #region Exercicio 090

            /*            
            Console.WriteLine("-*-*-*-*-* Programa *-*-*-*-*-\n");
            Console.Write("Escreva um numero para somar com um proximo numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Escreva o segundo numero para somar com o anterior: ");
            int n2 = int.Parse(Console.ReadLine());
            Procedimentos somador = new Procedimentos();
            somador.Somador(n1,n2);

            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();
            */

            #endregion

            #region Exercicio 091

            /*
            Console.WriteLine("-*-*-*-*-* Programa  *-*-*-*-*-\n");
            Console.Write("Escreva um numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Escreva um segundo numero: ");
            int n2 = int.Parse(Console.ReadLine());
            Procedimentos somador = new Procedimentos();
            somador.Maior(n1, n2);

            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();
            */

            #endregion

            #region Exercicio 092

            /*
            Console.WriteLine("-*-*-*-*-* Programa *-*-*-*-*-\n");
            Console.Write("Escreva um numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Procedimentos ParOuImpar = new Procedimentos();
            ParOuImpar.ParOuImpar(n1);

            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();
            */

            #endregion

            #region Exercicio 093

            /*
            Console.WriteLine("-*-*-*-*-* Programa *-*-*-*-*-\n");
            Console.Write("Escreva o numero inicial da contagem: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Escreva o numero final da contagem: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Escreva o pulo da contagem: ");
            int n3 = int.Parse(Console.ReadLine());
            Procedimentos Contador = new Procedimentos();
            Contador.Contador(n1, n2, n3);

            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();
            */

            #endregion

            #region Exercicio 094

            /*
            Console.WriteLine("-*-*-*-*-* Programa  *-*-*-*-*-\n");
            Console.Write("Escreva o numero total de Fibonacci: ");
            int n1 = int.Parse(Console.ReadLine());
            Procedimentos Fibonacci = new Procedimentos();
            Fibonacci.Fibonacci(n1);

            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();
            */

            #endregion

            #region Exercicio 095

            /*
            Console.WriteLine("-*-*-*-*-* Programa *-*-*-*-*-\n");
            Console.Write("Escreva um numero para somar com um proximo numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Escreva o segundo numero para somar com o anterior: ");
            int n2 = int.Parse(Console.ReadLine());
            Program Somar = new Program();
            Somar.Somar(n1,n2);
            
            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();
            */

            #endregion

            #region Exercicio 096

            /*
            Console.WriteLine("-*-*-*-*-* Programa *-*-*-*-*-\n");
            Console.Write("Escreva uma nota de 0 a 10: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Escreva outra nota de 0 a 10: ");
            int n2 = int.Parse(Console.ReadLine());
            Program Media = new Program();
            Media.Media(n1, n2);

            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();
            */

            #endregion

            #region Exercicio 097

            /*
            Console.WriteLine("-*-*-*-*-* Programa  *-*-*-*-*-\n");
            Console.Write("Escreva um numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Escreva um segundo numero: ");
            int n2 = int.Parse(Console.ReadLine());
            Program somador = new Program();
            somador.Maior(n1, n2);

            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();
            */

            #endregion

            #region Exercicio 098

            /*
            Console.WriteLine("-*-*-*-*-* Programa  *-*-*-*-*-\n");
            Console.Write("Escreva o numero inicial da contagem: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Escreva o numero final da contagem: ");
            int n2 = int.Parse(Console.ReadLine());
            Program SuperSomador = new Program();
            SuperSomador.SuperSomador(n1, n2);

            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();
            */

            #endregion

            #region Exercicio 099

            /*
            Console.WriteLine("-*-*-*-*-* Programa  *-*-*-*-*-\n");
            Console.Write("Escreva o numero a ser potencializado: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Escreva o numero da elevação: ");
            int n2 = int.Parse(Console.ReadLine());
            Program Potencia = new Program();
            Potencia.Potencia(n1, n2);

            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();
            */

            #endregion

            #region Exercicio 100

            /*
            Console.WriteLine("-*-*-*-*-* Programa *-*-*-*-*-\n");
            Console.Write("Escreva uma nota de 0 a 10: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Escreva outra nota de 0 a 10: ");
            int n2 = int.Parse(Console.ReadLine());
            Program Media = new Program();
            Media.Media(n1, n2);
            Program Situacao = new Program();
            Situacao.Situacao(n1, n2);

            Console.WriteLine("\n-*-*-*-*-*-*-*- Fim do Programa  -*-*-*-*-*-*-*-\n");
            Console.ReadKey();
            */

            #endregion

        }
        #region (Metodos / funções)
        public void Somar (int n1, int n2)
        {
            Console.WriteLine(" A soma do numero " + n1 + " + " + n2 + " é igual a: " + (n1+n2));
        }
        public void Media(int n1, int n2)
        {
            Console.WriteLine(" A média entre: " + n1 + " e " + n2 + " é igual a: " + ((n1 + n2) / 2));
        }
        public void Maior(double n1, double n2)
        {
            if (n1 > n2)
            {
                Console.WriteLine(" o numero: " + n1 + " é maior que: " + n2);
            }
            else
            {
                Console.WriteLine(" o numero: " + n2 + " é maior que: " + n1);
            }
        }
        public void SuperSomador(int n1, int n2)
        {
            int soma = n1;
            for (int i = n1; i < n2; i++)
            {
                Console.Write(" " + i + ">> ");
                soma += i;
            }
            Console.WriteLine("A soma da seguencia é " + soma);
        }
        public void Potencia(int n1, int n2)
        {
            int value = n1;
            for (int power = 0; power <= n2; power++)
                Console.WriteLine($"{value}^{power} = {(long)Math.Pow(value, power):N0} (0x{(long)Math.Pow(value, power):X})");

        }
        public void Situacao(int n1, int n2)
        {
            int media = ((n1 + n2) / 2);
            if (media <= 5)
            {
                Console.WriteLine(" Aluno reprovado.");
            }
            if ((media > 5) && (media <= 8))
            {
                Console.WriteLine(" Aluno recuperação.");
            }
            if (media > 8)
            {
                Console.WriteLine(" Aluno Aprovado.");
            }

            

        }
        #endregion
    }
}
