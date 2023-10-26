using System;

class aula05{
    static void Main(String[] args){
        string f1, f2, f3;
        double preco;
        double desconto;
        double valorDesconto;
        double total;

        f1 = "Maçã"; f2 = "Uva"; f3 = "Banana";
        preco = 0.50;
        desconto = 0.1;

        Console.WriteLine("Frutas: {0}, {1}, {2}", f1, f2, f3);

        valorDesconto = (preco * desconto);
        preco-= valorDesconto;

        Console.WriteLine("{0}:..........{1,15:c}", f1, preco);
        Console.WriteLine("Des:{0:p}.....{1,15:c}", desconto, valorDesconto);
        Console.WriteLine("tot:..........{0,15:c}", preco);
    }
}