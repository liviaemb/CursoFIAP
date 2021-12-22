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
                //CHECAR O TIPO DO TRI�NGULO
                if ( x == y && y == z )
                {
                    triangulo = "Equil�tero";
                }
                else if (x != y && y != z && x != z)
                {
                    triangulo = "Escaleno";
                }
                else
                {
                    triangulo = "Is�sceles";
                }

            }
           else
            {
                //BLOCO FALSO: OS LADOS N�O FORMAM UM TRI�NGULO
                MessageBox.Show("Os lados informados n�o formam um tri�ngulo!", "Aten��o",
                MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
        }
    }
}