namespace tipoTriangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int x, y, z;
            string triangulo;

            x= int.Parse(txtX.Text);
            y= int.Parse(txtY.Text);
            z= int.Parse(txtZ.Text);

            //VERIFICAR SE OS VALORES FORMAM UM TRIANGULO

           if(x < y + z && y < x + z && z < x + y)
            {
                //CHECAR O TIPO DO TRIÂNGULO
                if ( x == y && y == z )
                {
                    triangulo = "Equilátero";
                }
                else if (x != y && y != z && x != z)
                {
                    triangulo = "Escaleno";
                }
                else
                {
                    triangulo = "Isósceles";
                }

            }
           else
            {
                //BLOCO FALSO: OS LADOS NÃO FORMAM UM TRIÂNGULO
                MessageBox.Show("Os lados informados não formam um triângulo!", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
        }
    }
}