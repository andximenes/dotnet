using System;
using System.Collections.Generic;

class Teste
{
    
    static void Main()
    {
        Dictionary <int, string> veiculos = new Dictionary <int, string>();

        veiculos.Add(10, "Carro");
        veiculos.Add(5, "Avião");
        veiculos.Add(0, "Navio");
        veiculos.Add(20, "Moto");
        veiculos.Add(15, "Patinete");

        //veiculos.Clear(); limpa o dicionário.

        //veiculos.Remove(20); Remove

        Console.WriteLine($"Tamanho do Dictionary {veiculos.Count}");

        //método ContainsKey()
        int chave = 20;
        if(veiculos.ContainsKey(chave))
        {
            Console.WriteLine($"A chave {chave} está no dicionário");

        }else
        {
            Console.WriteLine($"A chave {chave} não está no dicionário");
        }

        //Método ContainsValue()
        string valor = "Navio";

        if(veiculos.ContainsValue(valor))
        {
            Console.WriteLine($"A chave {valor} está no dicionário");
        }else
        {
            Console.WriteLine($"A chave {chave} não está no dicionário");
        }

        veiculos[20] = "Locomotiva";

        Console.WriteLine(veiculos[20]);
        
        foreach (var item in veiculos)
        {
            Console.WriteLine(item);
        }
    }
}
