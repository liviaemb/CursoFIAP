namespace MediaAlunos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, media;
            n1= double.Parse(txtN1.Text);
            n2 = double.Parse(txtN2.Text);
            n3 = double.Parse(txtN3.Text);

            media = (n1 + n2 + n3) / 3;


            if (media <4)
            {
                 MessageBox.Show("Você foi reprovado!", "Resultado",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (media <7)
            {
                    MessageBox.Show ("Você está na recuperação!", "Resultado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("Você foi aprovado!", "Resultado",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}