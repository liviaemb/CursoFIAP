namespace IdadeMinima
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
            idade=byte.Parse(txtIdade.Text);
            if (idade >= 12)
            {
                MessageBox.Show("Você pode jogar!", "+ Jogos - Drogas",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Sua idade não permite que você jogue!", "Volte em breve",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}