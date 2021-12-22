namespace MediaGasolina
{
    public partial class Form1 : Form
    {
        double kmI, kmF, litros, sub, resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            lerValores();
            sub = kmF - kmI;
            resultado = sub / litros;
            lblResultado.Text = resultado.ToString("A autonomia deste veículo é: 0.00 Km/L");


        }

        private void lerValores()
        {
            kmI = Convert.ToDouble(txtKmI.Text);
            kmF = Convert.ToDouble(txtKmF.Text);
            litros = Convert.ToDouble(txtLitros.Text);


        }
    }
}