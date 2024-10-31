using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tarefa_do_zé;

namespace tarefa_do_ze
{
    internal class tarefa2
    {
        static void Main(string[] args)
        {


            Empregados funcionario1 = new Empregados("Jorge",2000, 10);
            Empregados funcionario2 = new Empregados("João", 3000, 15);
            Empregados funcionario3 = new Empregados("Juan", 4000, 20);

            funcionario1.Calc();
            funcionario2.Calc();
            funcionario3.Calc();

            Console.WriteLine("Nome :" + funcionario1.nome);
            Console.WriteLine("Aqui esta os valores desejados :" + funcionario1.salarioLiq);
            Console.WriteLine("Nome :" + funcionario1.nome);
            Console.WriteLine("Aqui esta os valores desejados :" + funcionario2.salarioLiq);
            Console.WriteLine("Nome :" + funcionario1.nome);
            Console.WriteLine("Aqui esta os valores desejados :" + funcionario3.salarioLiq);



        }

        
    }
}
