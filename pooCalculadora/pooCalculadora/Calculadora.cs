using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooCalculadora
{
    public class Calculadora
    {
        //ATRIBUTOS 

        public double n1 { get; set; }
        public double n2 { get; set; }
        public double res { get; set; }

        //CONSTRUTOR
        public Calculadora()
        {

            this.n1 = 0;
            this.n2 = 0;    
            this.res = 0;

        }

        //MÉTODOS QUE FAZER OS CÁLCULOS
        public void somar ()
        { 
            res = n1 + n2; 
        }
        public void subtrair ()
        {
            res = n1 - n2;
        }
        public void multiplicar ()
        {
            res = n1 * n2;
        }
        public void divisao ()
        {
            res = n1 / n2;
        }

    }
}
