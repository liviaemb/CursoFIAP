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
                    MessageBox.Show("Voc� selecionou o Itamb� Minas!");
                    break;
                case 1:
                    MessageBox.Show("Voc� selecionou o Praia Clube!");
                    break;
                case 2:
                    MessageBox.Show("Voc� selecionou o Sesc Flamengo!");
                    break;
                case 3:
                    MessageBox.Show("Voc� selecionou o Osasco S�o Crist�v�o!");
                    break;
                case 4:
                    MessageBox.Show("Voc� selecionou o Vakif Bank!");
                    break;
                case 5:
                    MessageBox.Show("Voc� selecionou o Conegliano!");
                    break;
                case 6:
                    MessageBox.Show("Voc� selecionou o Igor Novara!");
                    break;
                case 7:
                    MessageBox.Show("Voc� selecionou o LKS Commercecon!");
                    break;

                default:
                    MessageBox.Show("Selecione uma equipe!");
                    break; 
            }
        }
    }
}
