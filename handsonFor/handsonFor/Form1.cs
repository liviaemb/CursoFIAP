namespace handsonFor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            int n1, n2, res=0, cont; 


            n1 = int.Parse(txtN1.Text);
            n2 = int.Parse(txtN2.Text);
            cont = n1;

            lblRes.Text = "";

            if (n1 < n2) 
            {
                for  (cont = n1; cont <= n2; cont++)    
                {
                    res += cont; 
                }
                lblRes.Text = res.ToString(); 

            }
            else
            {
                MessageBox.Show("O primeiro número deve ser menor que o segundo!");
            }
        }
    }
}