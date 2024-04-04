#include <iostream>
#include <random>
using namespace std;

int main()
{
    cout<<"Digite o numero de horas que você treina por dia joven padawan"<<endl;
    int horas;
    cin>>horas;
    while(horas > 24){
        cout<<"tem algo de errado com esse numero de horas (verifique o numero de horas)"<<endl;
        cin>>horas;
    }
    int dias = 1000/horas;
    int semanas = dias/5;
    int meses = semanas/(9/2);
     cout<<"restão apenas "<<dias<<" dias, " <<semanas<< " semanas ou "<<meses<<" meses para chegar na meta de 1000 horas de treino"<<endl;
}