using System;

struct Carro
{
    public string marca;
    public string modelo;
    public string cor;

    public Carro(string marca, string modelo, string cor)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;
    }

    public void info()
    {   
     
        Console.WriteLine($"Marca: {this.marca}");
        Console.WriteLine($"Modelo: {this.modelo}");
        Console.WriteLine($"Cor: {this.cor}");
        
        
    }
}