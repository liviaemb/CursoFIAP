namespace opLogicoE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login, senha;
            login = txtUsuario.Text.ToUpper();
            senha = txtSenha.Text.ToUpper();

            if (login == "ADMINISTRADOR" && senha == "123")
            {
                MessageBox.Show("Bem-vindo administrador!", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Nome de usuário ou senha inválidos!", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }
    }
}