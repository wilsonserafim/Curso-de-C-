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

            string nome = "Wilson";

            for (int i = 0; i < nome.Length; i++)
            {
                label1.Text += nome[i] + "\n";
            }




            #endregion

        }
    }
}
