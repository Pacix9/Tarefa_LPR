using System;
class HelloWorld
{
  static void Main ()
  {
	  Console.WriteLine ("digite 2 numeros para verificarmos se eles são multiplos");
	   double N1 = double.Parse (Console.ReadLine ());
	   double N2 = double.Parse(Console.ReadLine());
	     if (N1%N2==0 || N2%N1==0){
	         Console.WriteLine("são multiplos");
	         
	     }
	     else{
	         Console.WriteLine("não são multiplos");
	     }
  }
}