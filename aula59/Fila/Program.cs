using System;
using System.Collections.Generic;

class Teste
{
    static void Main()
    {
        //string[] elementos = {"Carro","Moto", "Navio", "Avião"};
        //Queue<string> veiculos = new Queue<string>(elementos);

        Queue<string> veiculos = new Queue<string>();
        veiculos.Enqueue("Carro"); //Enqueue, adc itens no final da fila
        veiculos.Enqueue("Moto");
        veiculos.Enqueue("Navio");
        veiculos.Enqueue("Avião");

        //veiculos.Clear();

        Console.WriteLine($"Tamanho da Fila: {veiculos.Count}");
        
        //veiculos.Dequeue(); //Elimina o primeiro elemento da fila                                             
        //veiculos.Peek(); //Retorna o primeiro elemento da fila mas não remove
        
        //Método Contains()
        string elemento = "Avião";
        if(veiculos.Contains(elemento))
        {
            Console.WriteLine($"Veículo {elemento} encontrado");
        }else
        {
            Console.WriteLine($"Veiculo {elemento} não está na fila");
        }

        
    }
}
