using System;
class HelloWorld {
  static void Main() {
      
      double adicionador = 0;
      int contador = 0;
      int x = 0;
    Console.WriteLine("quantos numeros serão utilizados");
    int Ntotal = int.Parse(Console.ReadLine());
    while(contador < Ntotal)
    {
        Console.WriteLine("digite um dos numeros");
        double Num = double.Parse(Console.ReadLine());
        if(Num % 2 == 0)
        {
        adicionador = Num + adicionador;
        x++;
        }
        
        contador ++;
        
    }
    double Rfinal = adicionador / pares;
    Console.WriteLine("o resultado final é "+ Rfinal);
  }
}