namespace prjSwitchCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            byte codigo;

            if (byte.TryParse(txtCodigo.Text, out codigo) == false)
            {
                MessageBox.Show("Digite o código corretamente.");
                txtCodigo.Clear();  
                txtCodigo.Focus();
                return; 
            }

            switch (codigo)
            {
                case 1:
                    MessageBox.Show("Elogio profissional");
                    break;
               
                case 2:
                    MessageBox.Show("Elogio físico");
                    break ;
                
                case 3:
                    MessageBox.Show("Elogio pessoal");
                    break;
                
                default:
                    MessageBox.Show("Código inválido");
                    break;  
            }
        }
    }
}