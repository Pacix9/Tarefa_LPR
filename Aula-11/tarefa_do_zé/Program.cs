using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tarefa_do_ze;

namespace tarefa_do_ze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            retangulo x = new retangulo();

            Console.WriteLine("Digite a altura");
            x.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Largura");
            x.Largura = double.Parse(Console.ReadLine());

            x.calcArea();
            x.calcPerimetro();

            Console.WriteLine("o resultado da Area é: " + x.Area);
            Console.WriteLine("o resultado do perimetro é: " + x.Perimetro);

        }








    }
}
