#include <iostream>
main ()
{
  int N1, resultado;
   std::cout << "Digite um numero para verificarmos se ele é par ou impar";
   std::cin >> N1;
   resultado = N1 % 2;
    if(resultado == 0){
        std::cout << "seu numero é par";
    }
    else{
        std::cout << "seu numero é impar";
    }
}