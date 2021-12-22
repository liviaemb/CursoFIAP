using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraEscolar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1, n2, media, frequencia;
            int assistidas, totalAulas;
            n1 = double.Parse(txtN1.Text);
            n2 = double.Parse(txtN2.Text);
            assistidas = int.Parse(txtAssistidas.Text);
            totalAulas = int.Parse(txtAulas.Text);

            media = (n1 + n2) / 2;
            frequencia = (assistidas / totalAulas) * 100;


            if (media >= 7 && frequencia >= 75)
            {
                lblResultado.ForeColor = Color.Green;
                lblResultado.Text = $"Média: {media.ToString("0.00")} - Aprovado";

            }
            else
            {
                lblResultado.ForeColor = Color.Red;
                lblResultado.Text = $"Média: {media.ToString("0.00")} - Reprovado";
            }
        }
    }
}
