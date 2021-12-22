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


namespace matrizPares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPares_Click(object sender, EventArgs e)
        {
            int [,] valores = new int[3,2];
            int pares = 0;

            //ENTRADA DOS VETORES 
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna <2; coluna++)
                {
                    valores[linha, coluna] = int.Parse
                        (Interaction.InputBox($"Digite o número para a posição {linha.ToString()}, {coluna.ToString()}"));
                }
            }

            //PERCORRENDO UM VETOR
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    if (valores [linha, coluna] % 2 ==0)
                    {
                        pares++;
                    }
                }
            }

            //EXIBIR A MENSAGEM

            MessageBox.Show($"Quantidade de números pares: {pares.ToString()}");
        }
    }
}
