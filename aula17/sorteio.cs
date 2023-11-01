using System;
using System.Collections.Generic;

class sorteio{
    static void Main(){
        Random random = new Random();
        List<int> numAleatorios = new List<int>();
        int num;
        int nInicial;
        int nFinal;
        bool continuar = true;;

        Console.WriteLine("\nSorteia Números\n");
        Console.Write("Intervalo inicial: ");
        nInicial = int.Parse(Console.ReadLine());
        Console.Write("Intervalo Final: ");
        nFinal = int.Parse(Console.ReadLine());
        
     
        do{ 
            num = random.Next(nInicial, nFinal);
            numAleatorios.Add(num);

            foreach (int numeros in numAleatorios){
                Console.Write(numeros + " ");
            }

            String novoSorteio;

            Console.Write("\nDeseja sortear outro número? [s] ou [n]: ");
            novoSorteio = Console.ReadLine();

            if(novoSorteio == "s" || novoSorteio == "S"){
                continuar = true;
                Console.Clear();
            }else{
                continuar = false;
                Console.WriteLine("\nPrograma finalizado.");
            }
        }while(continuar);

    }
}