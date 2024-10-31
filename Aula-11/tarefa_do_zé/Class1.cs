using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa_do_ze
{
     class retangulo
    {

        public double Altura = 0;
        public double Largura = 0;
        public double Area = 0;
        public double Perimetro = 0;

        public void calcArea()
        {
            Area = Altura * Largura;
           

        }
        public void calcPerimetro()
        {
            Perimetro = 2 * (Largura + Altura);


        }


    }
 
}
