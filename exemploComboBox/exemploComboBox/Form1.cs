namespace exemploComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEscolha_Click(object sender, EventArgs e)
        {
            switch (cmbEscolha.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("Você selecionou o Itambé Minas!");
                    break;
                case 1:
                    MessageBox.Show("Você selecionou o Praia Clube!");
                    break;
                case 2:
                    MessageBox.Show("Você selecionou o Sesc Flamengo!");
                    break;
                case 3:
                    MessageBox.Show("Você selecionou o Osasco São Cristóvão!");
                    break;
                case 4:
                    MessageBox.Show("Você selecionou o Vakif Bank!");
                    break;
                case 5:
                    MessageBox.Show("Você selecionou o Conegliano!");
                    break;
                case 6:
                    MessageBox.Show("Você selecionou o Igor Novara!");
                    break;
                case 7:
                    MessageBox.Show("Você selecionou o LKS Commercecon!");
                    break;

                default:
                    MessageBox.Show("Selecione uma equipe!");
                    break; 
            }
        }
    }
}
