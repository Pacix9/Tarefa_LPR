using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace tarefa_do_zé
{
    internal class Empregados
    {

        public string nome;
        public double salarioBruto;
        public double salarioBrutoNV;
        public double salarioLiq;
        public double imposto;

        public Empregados(string person, double money, double percent)
        {
            nome = person;
            salarioBruto = money;
            imposto = percent;

        }
        public void Calc()
        {
            salarioBrutoNV = salarioBruto * (imposto/100);
            salarioLiq = salarioBruto + salarioBrutoNV;
    }
    }
}
