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

namespace vetorOrdemInversa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValores_Click(object sender, EventArgs e)
        {
            double[] vA = new double[15];
            double[] vB = new double[15];

            for (int i = 0; i < vA.Length; i++)
            {
                vA[i] = double.Parse(Interaction.InputBox($"Digite os valores:{(i + 1).ToString()}"));
                lstA.Items.Add(vA[i]); 

            }
            for (int i = 0;i < vB.Length; i++)
            {
                vB[i] = vA[vA.Length - 1 - i];
                lstB.Items.Add(vB[i]); 
            }

        }
    }
}
