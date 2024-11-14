using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_do_ze_2_2
{
    internal class Livro
    {
        Biblioteca VdaBiblioteca = new Biblioteca("livro");
        public int Id { get; set; }
        string titulo;
        string Autor; 
        int ano;
        public List<Biblioteca> Bibliotecas{ get; set; } = new List<Biblioteca>();
        public Livro(string titulo, string autor, int ano)
        {
            this.titulo = titulo;
            this.Autor = autor;
            this.ano = ano;

        }
        
       
    }
}
