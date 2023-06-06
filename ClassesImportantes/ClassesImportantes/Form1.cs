using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesImportantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMessengeBox_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Olá Meus Amigos");
            //MessageBox.Show("Mensagem Impressa", "Titulo da Mensagem");
            DialogResult res =  MessageBox.Show("Texto da Mensagem", "Titulo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (res == DialogResult.OK)
            {
                lblResultado.Text = "Clicou em Ok";
            }
            else if (res == DialogResult.Cancel)
            {
                lblResultado.Text = "Clicou em Cancel";
            }

        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            Random r = new Random(DateTime.Now.Millisecond);

            int valor = r.Next(101);
            double valor2 = r.NextDouble() * 100;

            lblResultado.Text = "Número: " + valor2;
        }

        private void btnTimeSpan_Click(object sender, EventArgs e)
        {
            //lblResultado.Text = TimeSpan.FromMinutes(60).ToString();

            TimeSpan inicio = new TimeSpan(5, 30, 03);

            TimeSpan fim = new TimeSpan(18, 25, 0);

            TimeSpan intervalo = fim - inicio;

            lblResultado.Text = intervalo.TotalHours.ToString();
        }
    }
}
