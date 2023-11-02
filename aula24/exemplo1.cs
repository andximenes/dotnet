using System;

class exemplo1{
    static void Main(){
        Console.WriteLine("Cadastro");
        newLine();
        cadastro("Joaozinho","22", "123.456.789-12", "SP", "Barueri", "(11) 91234-5678");
    }
   
    //Pula linha
    static void newLine(){
        Console.WriteLine();
    }
    //imprime cadastro
    static void cadastro(string nome, string idade, string cpf, string uf, string cidade, string telefone){
        Console.WriteLine("Nome: {0}", nome);
        Console.WriteLine("Idade: {0}", idade);
        Console.WriteLine("CPF: {0}", cpf);
        Console.WriteLine("UF: {0}", uf);
        Console.WriteLine("Cidade: {0}", cidade);
        Console.WriteLine("Telefone: {0}", telefone);
    }
    
}