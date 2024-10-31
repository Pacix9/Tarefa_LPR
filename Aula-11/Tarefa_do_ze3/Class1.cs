using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_3
{
    internal class Aluno
    {
        internal int matricula;
        internal string nome;
        internal double notapvr1;
        internal double notapvr2;
        internal double trabalho;
        internal double mediaNota;
        internal double falta;

        public Aluno(int estudante, string name, double nota1, double nota2, double nota3)
        {
            matricula = estudante;
            nome = name;
            notapvr1 = nota1;
            notapvr2 = nota2;
            trabalho = nota3;

        }

        internal double media()
        {
            mediaNota = (((2.5 * (notapvr1 + notapvr2)) + (2 * trabalho)) / 2);

            return mediaNota;
        }

        internal double final()
        {
            if (mediaNota < 60)
            {

                return 0;
            }
            else
            {
                falta = 100 - mediaNota;

                return falta;
            }
        }
    }
}