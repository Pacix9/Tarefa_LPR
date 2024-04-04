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
    Console.WriteLine("digite o numero");
    int numInicial = int.Parse(Console.ReadLine());
    int numParaSeparar = numInicial * numInicial;
    while (numParaSeparar > 0) {
            int numSeparados = numParaSeparar % 10; 
            soma += numSeparados;
            numParaSeparar /= 10; 
        }
        Console.WriteLine("soma dos dígitos do quadrado desse número é " + soma);
  }
}