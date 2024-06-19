#include <iostream>
#include <array>
using namespace std;

 struct Livro {
      string Titulo;
      string Autor;
      string DPublicacao;
      int NPaginas;
      int Preco;
    };
    
  int main() {
      array<Livro,3> Livraria;
    Livraria[0] = {"Diario de um banana 7", "Jeff Kinney", "13/11/2012", 226, 30};
    Livraria[1] = {"Percy Jackson e o Ladrão de Raios", "Rick Riordan", "28/06/2005", 400 , 40};
    Livraria[2] = {"Dom Casmurro", "Machado de Assis", "1899", 398 , 50};
    float R = 0;
    
for (Livro livro : Livraria){
      R+=livro.Preco;
 }

 float media = R/Livraria.size();
 
    cout << "O preço total dos livros é: " << endl;
    cout <<"Diario de um banana 7 = R$30,00 "<< endl;
    cout <<"Percy Jackson e o Ladrão de Raios = R$40,00"<< endl;
    cout <<"Dom Casmurro = R$50,00 "<< endl;
    cout <<"e a media de paginas é: " << media << endl;

   
}