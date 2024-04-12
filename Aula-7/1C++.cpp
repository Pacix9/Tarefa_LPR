#include <iostream>
using namespace std;

void reverse(int Numero){
    int NumReverse = 0;
    while(Numero){
        NumReverse *= 10;
        NumReverse += Numero%10;
        Numero /= 10;
    }
    
    cout << "o numero invertido sera "<<NumReverse<<endl;
    
}
int main()
{
    
    cout<<"Digite um numero"<<endl;
    int Num;
    cin>>Num;
    reverse(Num);

    return 0;
}