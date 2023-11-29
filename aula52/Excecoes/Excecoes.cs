using  System;

class Excecoes
{
    static void Main()
    {
        int n1 = 10;
        int n2 = 5;
        int resposta;

        try
        {
            resposta = n1 / n2;
            Console.WriteLine($"{resposta}");
            throw new Exception("Gerando um erro proposital;");
        }
        catch(Exception e)
        {
            Console.WriteLine($"Erro: {e.Message}");
        }finally
        {
            Console.WriteLine("Fim do processo"); //execução independente
        }
    }
}
