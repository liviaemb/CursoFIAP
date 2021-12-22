namespace ifComposto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInvestimento_Click(object sender, EventArgs e)
        {
            double donation, investimento;

            donation = double.Parse(txtValor.Text);

            if (donation <= 1000)
            {
                investimento = donation * 0.05;
            }
            else
            {
                investimento = donation * 0.15;
            }
            MessageBox.Show($"O valor do investimento deverá ser de R${investimento.ToString("0.00")}",
                "Doação - ONG", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}