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

namespace matrizSoma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            int[,] valores = new int[2, 2];
            int soma = 0; 

            //ENTRADA DOS VETORES 
            for (int linha = 0; linha < 2; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    valores[linha, coluna] = int.Parse
                        (Interaction.InputBox($"Digite o número para a posição {linha.ToString()}, {coluna.ToString()}"));
                    soma += valores[linha, coluna];

                }
            }

            //EXIBIR A MENSAGEM

            MessageBox.Show($"Soma: {soma.ToString()}");
        }
    }
}
