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
                 MessageBox.Show("Voc� foi reprovado!", "Resultado",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (media <7)
            {
                    MessageBox.Show ("Voc� est� na recupera��o!", "Resultado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("Voc� foi aprovado!", "Resultado",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}