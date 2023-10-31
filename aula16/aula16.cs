using System;

class aula16{
    static void Main(String[] args){
        
        String resp;
        
        inicio: 

        Console.WriteLine("bot: Olá tudo bem?");
        Console.Write("Você: ");
        resp = Console.ReadLine();
        
        if(resp == "s" || resp == "S"){
            Console.WriteLine("{0} e você?", resp);
            Console.WriteLine("Que bom!");
        } else{
            Console.WriteLine("humm. Entendo\n");
            
        }

        Console.WriteLine("Deseja Continuar nossa conversa? [s] ou [n]");

        String continuar ;
        continuar = Console.ReadLine();
        if(continuar == "s" || continuar == "S"){
            goto inicio;                        
        } else {
            Console.Clear();
            Console.WriteLine("Fim do Programa");
        }

    }
}