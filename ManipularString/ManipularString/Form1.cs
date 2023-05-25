using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipularString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecultar_Click(object sender, EventArgs e)
        {

            #region Contains / ToString

            /*
            string texto = "Este tipo de Variavel é alfanumerica";

            if (texto.Contains("Tipo"))
            {
                label1.Text = "Contem.";
            }
            else
            {
                label1.Text = "Não Contem.";
            }

            int num = 540015478;
            bool res = true;


            label1.Text = num.ToString();
            label1.Text = res.ToString();
            */
            #endregion

            #region ToUpper / ToLower

            //string nome = "gabriel";

            //label1.Text = nome.ToUpper();

            //string nome = "WILSON";

            //label1.Text = nome.ToLower();

            #endregion

            #region IndexOf / LastIndexOf

            //string nome = "Wilson Serafim da";

            //int indice =nome.LastIndexOf("a");

            //label1.Text = "Indice: " + indice;


            //string nome = "Wilson Serafim da";

            //int indice =nome.LastIndexOf("a");

            //label1.Text = "Indice: " + indice;

            #endregion

            #region Insert / Replace

            //string nome = "Gabriel Artigas";

            //string nomeFinal = nome.Insert(0, "Lucas ");

            //label1.Text = nomeFinal;

            //string nome = "Gabriel Artigas";

            //string nomeFinal = nome.Replace("a","x");// serve para fazer as mascaras de CPF CNPJ

            //label1.Text = nomeFinal;

            #endregion

            #region Length - SubString

            //string nome = "Gabriel Artigas";

            //int tam = nome.Length;

            //label1.Text = "O nome contem: " + tam + " caracteres.";

            //string nome = "Wilson Serafim";

            //for (int i = 0; i < nome.Length; i++)
            //{
            //    label1.Text += nome[i] + "\n";
            //}

            //string parte = nome.Substring(nome.IndexOf(" "), 7);
            //label1.Text = parte;




            #endregion

            #region Split

            //string nomes = "Wilson Dany Giovanna Giulia Andréa Bia Flavio";

            //char[] separador = { ' ' };

            //string[] resultado = nomes.Split(separador);

            //foreach (string nome in resultado) 
            //{
            //    label1.Text += nome + "\n";
            //}


            #endregion

            #region Starts - EndsWith

            //string nomes = "Wilson Dany Giovanna Andréa Bia Flavio";

            //bool res = nomes.StartsWith("Wil");
            //bool res = nomes.EndsWith("O");

            //if (res)
            //{
            //    label1.Text = "Positivo";
            //}
            //else
            //{
            //    label1.Text = "Negativo";
            //}


            #endregion

            #region Trim - TrimStart - TrimEnd

            //string mensagem = "    Olá Wilson      ";

            //char[] c = { ' ', '-', '_', '5' };
            //string nova = mensagem.Trim(c);

            //label1.Text = ">" + mensagem.TrimStart() + "<";

            //label1.Text = ">" + mensagem.TrimEnd() + "<";


            #endregion

            #region CompareTo - Equals

            //string nome = "Widslson";
            //string nome2 = "wilson";

            //if (nome.Equals(nome2, StringComparison.OrdinalIgnoreCase))
            //{
            //    label1.Text = "Positivo";
            //}
            //else
            //{
            //    label1.Text = "Negativo";
            //}

            //label1.Text = nome.CompareTo(nome2).ToString();


            #endregion

            #region Format

            //decimal valor = 19.95m;
            //int temp = 32;

            //string s = String.Format("A temperatura é {1}", valor, temp);

            //string s = String.Format("Hoje é {0:d} e são {0:t}", DateTime.Now);

            //string s = String.Format("Hoje é {0:D} e são {0:T}", DateTime.Now);

            //string s = $"O valor do produto é {valor:C2} e a temperatura é {temp}°";

            //string s = $"Data: {DateTime.Now:T} \nHora:{DateTime.Now:T}";


            //label1.Text = s;


            #endregion

        }
    }
}
