using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colecoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            string[] nomes = new string[3];
            nomes[0] = "Wilson";
            nomes[1] = "Andréa";
            nomes[2] = "Giovanna";

            List<string> nomes2 = new List<string>();

            nomes2.Add("Lucas");
            nomes2.Add("Beatriz");
            nomes2.AddRange(nomes);

            /*
            lista.Items.Add(nomes2[1]);
            lista.Items.Add(nomes2[0]);
            lista.Items.Add(nomes2[2]);
            lista.Items.Add(nomes2[3]);
            lista.Items.Add(nomes2[4]);
            

            if (nomes2.Remove("Lucas"))
            {
                MessageBox.Show("Lucas Removido, ");
            }
            else
            {
                MessageBox.Show("Não foi possivel remover");
            }
            

            if (nomes2.Contains("sAndréa"))            
            {
                MessageBox.Show("Contem!!!");
            }
            else
            {
                MessageBox.Show("Não Contem!!!");
            }
            

            MessageBox.Show("Numero de Elementos: " + nomes2.Count);

            nomes2.Sort(); //classifica em ordem alfabetica.
            
            */

            //MessageBox.Show("o numero do Elemento Wilson é: " + nomes2.IndexOf("Wilson"));

            //nomes2.Insert(2, "Alberto");

            //nomes2.RemoveAt(1);

            //nomes2.Clear();



            MessageBox.Show("o numero do Elemento Wilson é: " + nomes2.IndexOf("Wilson"));

            foreach (string nome in nomes2)
            {
                lista.Items.Add(nome);
            }


        }

        private void btnHashSet_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            HashSet<string> veiculo = new HashSet<string>()
            {
                "Carro", "Moto", "Avião", "Helicoptero", "Barco"
            };

            //if (veiculo.Add("Moto"))
            //{
            //    MessageBox.Show("Conseguiu adicionar o veiculo");
            //}
            //else
            //{
            //    MessageBox.Show("Não conseguiu adicionar o veiculo");
            //}

            //if (veiculo.Contains("Moto"))
            //{
            //    MessageBox.Show("A lista já tem o veiculo");
            //}
            //else
            //{
            //    MessageBox.Show("A lista Não tem o veiculo");
            //}

            string remove = "Mosto";

            if (veiculo.Remove(remove))
            {
                MessageBox.Show("conseguimos remover, pois o veiculo: " + remove + " existe na lista");
            }
            else
            {
                MessageBox.Show("não conseguimos remover, pois o veiculo: " + remove + " não existe na lista");
            }



            foreach (string item in veiculo)
            {
                lista.Items.Add(item);
            }
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> alunos = new Dictionary<string, string>()
            {
                { "1", "Lucas" },
                { "2", "Teste" },
                { "3", "João" }
            };

            alunos.Add("50", "Wilson");

            alunos.Remove("3");

            foreach (KeyValuePair<string, string> item in alunos)
            {
                lista.Items.Add(item.Key + " = " + item.Value);
            }



            MessageBox.Show("Quantidade de Aluno: " + alunos.Count);
        }

        private void btnSortedList_Click(object sender, EventArgs e)
        {
            SortedList<int, string> alunos = new SortedList<int, string>() // organiza a lista por chave
            {
                { 27, "Wilson" },
                { 7, "Teste" },
                { 8, "Andréa" },
                { 3, "Giovanna" },
                { 5, "Cesar" }
            };

            alunos.Add(50, "Otavio");

            foreach (KeyValuePair<int, string> item in alunos.Reverse())
            {
                lista.Items.Add(item.Key + " = " + item.Value);
            }
        }
    }
}