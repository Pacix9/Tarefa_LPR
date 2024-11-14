using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class carro
    {
        int velocidade;
        public carro()
        {

            this.velocidade = 120;
        }
        public int vm
        {
          get
            {
                return this.velocidade; 
            }

            set
            {
                int resposta;
                resposta = int.Parse(Console.ReadLine());
                if(resposta < 0)
                {
                    velocidade  = 0;
                }
                else if(resposta > 300) {
                    velocidade = 300;
                
                }
                else
                {
                    velocidade = resposta;  
                }

            }
        }





      

    }
}
