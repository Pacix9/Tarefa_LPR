#include <iostream>
#include <random>
using namespace std;

int main()
{
    int tentativas = 0;
    int num;
    random_device numAleatorio ;
    uniform_int_distribution<> distribuicao(1,100);
    int valorInteiro = distribuicao(numAleatorio);
       cout<<"Digite um numero de 1 a 100"<<endl;
       int NumeroParaAdivinhar = distribuicao(numAleatorio);
    
    do{
        tentativas ++;
        cin>>num;
        if(num == NumeroParaAdivinhar){
            cout<<"NICE ONE! Você acertou!!"<<endl;
        }
        if(num > NumeroParaAdivinhar){
            cout<<"Calma lá patrão, chutou alto"<<endl;
        }
        if(num < NumeroParaAdivinhar){
            cout<<"Tá mirando baixo ein, mire mais alto"<<endl;
        }
    }
    while(num != NumeroParaAdivinhar);
    cout<<"Você precisou de "<<tentativas<< " tentativas."<<endl;
}