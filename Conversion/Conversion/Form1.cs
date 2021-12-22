namespace Conversion
{
    public partial class Form1 : Form
    {
        //DECLARA��O DE VARI�VEIS
        double n1, n2, res; //VALORES NUM�RICOS COM AT� 8 CASAS DECIMAIS

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConversion_Click(object sender, EventArgs e)
        {
            //LEITURA DOS VALORES
            lerValores();

            //C�LCULO
            res = n1 * n2;

            //SA�DA
            lblResultado.Text = res.ToString("R$ 0,00");
        }
        private void lerValores()
        {

            //LEITURA DOS VALORES 
            n1 = Convert.ToDouble(txtDolar.Text);
            n2 = Convert.ToDouble(txtCotacao.Text);
        }
    }
}