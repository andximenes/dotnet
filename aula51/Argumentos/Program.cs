using  System;

class Excecoes
{
    static void Main()
    {
        int n1 = 10;
        int n2 = 0;
        int resposta;
        try
        {
            resposta = n1 / n2;
            Console.WriteLine($"{resposta}");
        }
        catch
        {
            Console.WriteLine("Erro");
        }
    }
}