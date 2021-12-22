namespace TransporteVotar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            byte idade;
            idade = byte.Parse(txtIdade.Text);

            if (idade < 16)
            {
                MessageBox.Show("Voc� n�o pode votar e nem embarcar!", "Verifica��o",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (idade <18)
            {
                MessageBox.Show("Voc� pode votar e embarcar, voc� decide!", "Verifica��o",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Voc� deve votar e embarcar!", "Verifica��o",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}