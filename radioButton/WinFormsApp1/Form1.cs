namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (rbtFeminino.Checked==true)
            {
                MessageBox.Show("Selecionado sexo feminino!");
            }
            else
            {
                MessageBox.Show("Selecionado sexo masculino!");
            }

            if (rbtJava.Checked==true)
            {
                MessageBox.Show("Você escolheu JavaScript");
            }
            else if (rbtNet.Checked==true)
            {
                MessageBox.Show("Você escolheu .NET");
            }
            else
            {
                MessageBox.Show("Você escolheu C#"); 
            }
        }
    }
}