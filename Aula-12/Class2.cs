using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_do_ze_2_2
{
    
    internal class Biblioteca
    {
        public int Id { get; set; }
        string nome;

        Livro Comedia = new Livro("diario de um banana", "Um banana", 2014);
        public List<Livro> Livros {get; set;} = new List<Livro>();
        public Biblioteca(string titulo)
        {
             nome = titulo;

        }

        public void Adicionar()
        {
            string resposta1;

            string resposta2;

            int resposta3;

                resposta1 = Console.ReadLine();
                resposta2 = Console.ReadLine();
                resposta3 = int.Parse(Console.ReadLine());

                Livro SIM = new Livro(resposta1, resposta2, resposta3);
            Console.WriteLine(resposta1);
            Console.WriteLine(resposta2);
            Console.WriteLine(resposta3);


        }



    }
}
