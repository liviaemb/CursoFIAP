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
                MessageBox.Show("Você não pode votar e nem embarcar!", "Verificação",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (idade <18)
            {
                MessageBox.Show("Você pode votar e embarcar, você decide!", "Verificação",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Você deve votar e embarcar!", "Verificação",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}