using Exercício_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Tarefa_do_ze3

{
    internal class Program
    {
        static void Main(string[] args)
        {

            Aluno aluno = new Aluno();

         
            Console.WriteLine("Digite a matrícula do aluno: ");
            aluno.matricula = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do aluno:");
            aluno.nome = Console.ReadLine();
            Console.WriteLine("Digite a nota da primeira prova:");
            aluno.notapvr1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota da segunda prova:");
            aluno.notapvr2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do trabalho:");
            aluno.trabalho = int.Parse(Console.ReadLine());



            Console.WriteLine("Nome: "+aluno.nome);
            Console.WriteLine("Matricula: "+aluno.matricula);


            Console.WriteLine("Média: " + aluno.media());                                         
                        Console.WriteLine("A nota necessária é " + aluno.final());                                                                           
                        
                        
                
            }
        }
    }

