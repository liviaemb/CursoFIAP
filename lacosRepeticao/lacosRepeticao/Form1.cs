namespace lacosRepeticao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            lstTabuada.Items.Clear();
            int num, res;
            int cont = 1;

            num = int.Parse(txtNumero.Text);

            while (cont <= 10)
            {
                res = num * cont;
                lstTabuada.Items.Add(res.ToString()); // Inserindo valores na list box
                cont++; // Adiciona 1 ao contador 

            }
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            lstTabuada.Items.Clear();
            int num, res;
            int cont = 1;

            num = int.Parse(txtNumero.Text);

            do
            {
                res = num * cont;
                lstTabuada.Items.Add(res.ToString()); // Inserindo valores na list box
                cont++; // Adiciona 1 ao contador 

            } while (cont <= 10);
        }

        private void btnTabuada_Click(object sender, EventArgs e)
        {
            lstTabuada.Items.Clear();
            int num, res;

            num = int.Parse(txtNumero.Text);

            res = num * 1;
            lstTabuada.Items.Add(res.ToString());
            res = num * 2;
            lstTabuada.Items.Add(res.ToString());
            res = num * 3;
            lstTabuada.Items.Add(res.ToString());
            res = num * 4;
            lstTabuada.Items.Add(res.ToString());
            res = num * 5;
            lstTabuada.Items.Add(res.ToString());
            res = num * 6;
            lstTabuada.Items.Add(res.ToString());
            res = num * 7;
            lstTabuada.Items.Add(res.ToString());
            res = num * 8;
            lstTabuada.Items.Add(res.ToString());
            res = num * 9;
            lstTabuada.Items.Add(res.ToString());
            res = num * 10;
            lstTabuada.Items.Add(res.ToString());

        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            lstTabuada.Items.Clear();
            int num, res;
            int cont = 1;

            num = int.Parse(txtNumero.Text);

            for (cont=1; cont<=10; cont++) 
            {
                res = num * cont;
                lstTabuada.Items.Add(res.ToString()); // Inserindo valores na list box

            }
        }
    }
}