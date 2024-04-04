/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {

      int soma = 0;
      for (int i = 50; i <= 500; i++)
      
     if (i % 2 != 0 && i % 3 == 0){
         soma += i;
         Console.WriteLine("O resultado é:"+ soma);
     }
  }
}