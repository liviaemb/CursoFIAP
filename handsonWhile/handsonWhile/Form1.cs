namespace handsonWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lstFatorial.Items.Clear();
            double num;
            double res = 1; 

            num = double.Parse(txtNumero.Text);

            while (num != 1) //tem que se atentar para quando precisar usar o 1, tamb�m pode (num>1)
            {
                res = res * num;
                num = num - 1; // ou num--; tamb�m funciona
                lstFatorial.Items.Add(res.ToString());

            }

        }
    }
}