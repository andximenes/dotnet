using System;

class Teste
{
    static void Main()
    {
        Carro carro = new Carro();
        carro.vm = 200;
        Console.WriteLine($"Velocidade {carro.vm}");
    }
}
