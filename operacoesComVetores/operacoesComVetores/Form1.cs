using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace operacoesComVetores
{
    public partial class Form1 : Form
    {
        //DECLARAR O ARRAY
        String[] cores = { "vermelho", "laranja", "amarelo", "verde", "azul", "roxo" };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTamanho_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Seu vetor tem capacidade para ler {cores.Length.ToString()}");

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Clear();
            Array.Sort(cores);
            for (int i = 0; i < cores.Length; i++)
            {
                lstResultados.Items.Add(cores[i].ToString());

            }
        }

        private void btnInverter_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Clear();
            Array.Reverse(cores); //INVERTE A ORDEM SEM SER NA ORDEM ALFABÉTICA
            for (int i = 0; i < cores.Length; i++)
            {
                lstResultados.Items.Add(cores[i].ToString());

            }

        }

        private void btnBinaria_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Clear ();
            Array.Sort(cores);
            object corEscolhida = Interaction.InputBox("Digite a cor desejada");
            int indice = Array.BinarySearch(cores, corEscolhida);  
            if (indice >= 0)
            {
                MessageBox.Show($"Achei o elemento no indíce {indice.ToString()}"); 

            }
            else
            {
                MessageBox.Show("Não encontrei este elemento.");

            }

        }

        private void btnIndice_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Clear ();
            string busca = Interaction.InputBox("Digite a cor desejada"); 
            int resultado = Array.IndexOf(cores, busca);
            MessageBox.Show($"O índice onde o elemento está é o {resultado.ToString()}");

        }
    }
}
