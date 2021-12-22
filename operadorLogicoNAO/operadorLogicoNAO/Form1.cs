namespace operadorLogicoNAO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string usuario;
            usuario = txtUsuario.Text;

            if (!(usuario == "ADMINISTRADOR")) 
            {
                MessageBox.Show("Acesso negado!");
            }
        }
    }
}