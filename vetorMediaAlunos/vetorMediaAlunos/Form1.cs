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

namespace vetorMediaAlunos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            double[] v = new double[10];
            double total = 0;
            double media; 

            for (int i = 0; i < v.Length; i++)
            {
                v[i] = double.Parse(Interaction.InputBox($"Digite as notas dos alunos!{(i + 1).ToString()}"));
                total += v[i];

            }
            media = total / v.Length; 

            MessageBox.Show($"A média da turma é:{media.ToString("0.00")}");
        }
    }
}
