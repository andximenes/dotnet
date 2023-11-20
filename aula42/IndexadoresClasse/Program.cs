using System;

class Teste
{
    static void Main()
    {
        Numero numero = new Numero();
        numero[3] = 200;
        Console.WriteLine($"{numero[3]}");
    }
}
