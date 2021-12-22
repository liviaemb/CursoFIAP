namespace controleCaixa
{
    public partial class Form1 : Form
    {
        double saldo = 0; 
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            double valor=0; 

            if (!(cmbOpcao.SelectedIndex == 2))
            { 
               if (double.TryParse(txtValor.Text, out valor) == false)
               {
                MessageBox.Show("Digite um valor v�lido");
                txtValor.Clear();
                txtValor.Focus();
                return;
               }
            }
            
            switch (cmbOpcao.SelectedIndex)
            {
                case 0:
                    saldo += valor; //saldo = saldo + valor 
                    MessageBox.Show("Dep�sito efetuado!");
                    break;
                case 1:
                    saldo -= valor; //saldo = saldo - valor 
                    MessageBox.Show("Saque efetuado!");
                    break;
                case 2:
                    MessageBox.Show($"Seu saldo � de R${saldo.ToString("0.00")}");
                    break;
                default:
                    MessageBox.Show("Op��o inv�lida!");
                    break; 

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbOpcao.SelectedIndex = 0; 
        }
    }
}