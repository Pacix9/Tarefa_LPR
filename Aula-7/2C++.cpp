// 2C++.cpp : Este arquivo contém a função 'main'. A execução do programa começa e termina ali.
//

#include <iostream>
using namespace std;
 
void codigo1() {

    double adicionador = 0;
     int contador = 0;
     int x = 0;
       cout<<"quantos numeros serao utilizados"<<endl;
      int Ntotal;
      cin >> Ntotal;
       while (contador < Ntotal)
    {
           cout<<"digite um dos numeros"<<endl;
           int Num;
           cin >> Num;
           if (Num % 2 == 0)
        {
            adicionador = Num + adicionador;
            x++;
        }
        contador++;

    }
       double Rfinal = adicionador / x;
    cout << "o resultado final sera " << Rfinal << endl;
}
void codigo2() {

    int soma = 0;
    for (int i = 50; i <= 500; i++) {

        if (i % 2 != 0 && i % 3 == 0) {
            soma += i;
        }
    }
    cout << "O resultado sera: " << soma << endl;
}

void codigo3() {
    int soma = 0;
    cout << "digite um numero" << endl;
    int numInicial;
    cin >> numInicial;
    int numParaSeparar = numInicial * numInicial;
    while (numParaSeparar > 0) {
        int numSeparados = numParaSeparar % 10;
        soma += numSeparados;
        numParaSeparar /= 10;
    }
    cout << "soma dos digitos do quadrado desse numero sera " << soma << endl;
}


    
int main()
{
    cout << "escolha um dos modos de calculo" << endl;
    cout << "(1) media aritmedica" << endl;
    cout << "(2) A soma de todos os numeros impares multiplos de 3 que se encontrem no conjunto dos numeros de 50 a 500" << endl;  
    cout << "(3) soma dos digitos do quadrado desse numero." << endl;
    int escolha;
    cin >> escolha;
    switch (escolha) {
    case 1:
        codigo1();
        break;

    case 2:
        codigo2();
        break;

    case 3:
        codigo3();
        break;
    }
   
}

