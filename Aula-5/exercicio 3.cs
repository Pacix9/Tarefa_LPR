using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Classes disponiveis (Guerreiro, Mago e Arqueira)");
    Console.WriteLine("Escolha sua classe (1 para Guerreiro) (2 para Mago) (3 para Arqueira).");
    int resp = int.Parse(Console.ReadLine());
    
    switch (resp) {
        case 1:
        Console.WriteLine("Guerreiro");
        Console.WriteLine("Habilidades: Ataque Pesado e Defesa Total.");
        break;
        
        case 2:
        Console.WriteLine("Mago.");
        Console.WriteLine("Habilidades: Bola de Fogo, Escudo de Gelo.");
        break;
        
        case 3:
        Console.WriteLine("Arqueira.");
        Console.WriteLine("Habilidades: Flecha Precisa, Disparo Triplo.");
        break;
        
        default:
        Console.WriteLine("Algo deu errado tente novamente");
        break;
  }
}
}