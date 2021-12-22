namespace handsonDowhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPares_Click(object sender, EventArgs e)
        {
            //EXEMPLO COM EXTREMOS DE INTERVALO
            double n1, n2, res=0, cont;
            n1 = double.Parse(txtN1.Text);
            n2 = double.Parse(txtN2.Text);
            cont = n1;

            lblRes.Text = "";

            if (n1 < n2)
            {
                do
                {
                    if (cont % 2 == 0)
                    {
                        res++;
                    }
                    cont++;
                }
                while (cont <= n2);
                lblRes.Text =res.ToString(); 
            }
            else
            {
                MessageBox.Show("O primeiro número deve ser menor que o segundo!");
            }
        }
    }
}