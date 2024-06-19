/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

 public struct Produto {
        public string nome;
        public string codigo;
        public int preco;
        public int quantidade;
        
    }
    
class HelloWorld {
  static void Main() {
      Produto[] Mercadinho = new Produto[3];
    Mercadinho[0] = new Produto {nome = "Leite Integral", codigo = "D4869XHY", preco = 5, quantidade = 100};
    Mercadinho[1] = new Produto {nome = "Shampoo Dove cabelos cacheados", codigo = "D6731HTZ", preco = 20, quantidade = 70};
    Mercadinho[2] = new Produto {nome = "caixa de bis", codigo = "D0583JPCQ", preco = 6, quantidade = 120 };
    float R = 0;
    
foreach (Produto produto in Mercadinho){
   R += produto.preco*produto.quantidade;

 }

 

    Console.WriteLine("O valor total em estoque dos 3 produtos respectivamente são: "+ R);

   
  }
}
