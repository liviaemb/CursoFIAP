namespace operadorLogicoOu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double compra;
            string cupom;

            compra = double.Parse(txtCompra.Text);
            cupom = txtCupom.Text.ToUpper();

            if(compra >=1000 || cupom == "DESCONTO 20")
            {
                compra = compra - (compra * 0.2);

            }
            MessageBox.Show($"Total a pagar: R$ {compra.ToString("0.00")}");

        }
    }
}