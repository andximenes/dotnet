class Program
{
    static void Main()
    {
        //Titulares
        Titular titular1 = new Titular("Pedro Alves", "2341232", "08966756711", "(61) 98867-6421", "pedro@exemplo.com", "Médico", 15000);
        Titular titular2 = new Titular("Ana Alves", "3211888", "87899656718", "(61) 95643-4429", "ana@exemplo.com", "Engenheiro", 5000);

        titular1.dadosTitular();
        titular2.dadosTitular();

        Console.WriteLine($"{titular1.nome} Saldo em conta: R${titular1.getSaldo()}");
        Console.WriteLine($"{titular2.nome} Saldo em conta: R${titular2.getSaldo()}\n");

        titular1.Deposita(1000);
        titular2.Deposita(1000);

        Console.WriteLine($"{titular1.nome} Saldo em conta: R${titular1.getSaldo()}");
        Console.WriteLine($"{titular2.nome} Saldo em conta: R${titular2.getSaldo()}\n");

        titular1.Saca(1000);
        titular2.Transfere(titular1, 200);
       
        Console.WriteLine($"{titular1.nome} Saldo em conta: R${titular1.getSaldo()}");
        Console.WriteLine($"{titular2.nome} Saldo em conta: R${titular2.getSaldo()}");

    }
}