namespace CashbackEmpresa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCredito_Click(object sender, EventArgs e)
        {
            double saldo, credito;

            if (double.TryParse(txtSaldo.Text, out saldo) == false)
            {
                MessageBox.Show("Digite um número válido!", "ATENÇÃO",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSaldo.Clear(); //limpa a texbox
                txtSaldo.Focus(); //posiciona o cursor no componente 
                lblCredito.Text = ""; //limpa a label
                return; //abortar 
            }
            if (saldo <= 200)
            {
                credito = 0;
            }
            else if (saldo <= 400)
            {
                credito = saldo * 0.2;
            }
            else if (saldo <= 600)
            {
                credito = saldo * 0.3;
            }
            else
            {
                credito = saldo * 0.4;
            }
            lblCredito.Text = $"Seu crédito é: R${credito.ToString("0.00")}";
        }
    }
}