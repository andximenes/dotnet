using System;

class Argumento
{
    static void Main(string[] args)
    {
        if(args.Length > 0)
        {
            Console.WriteLine($"Quantidade de Argumentos: {args.Length}");
        }
        else
        {
            Console.WriteLine("Não foram passados argumentos");
        }

        Console.WriteLine(args[0]);
    }
}