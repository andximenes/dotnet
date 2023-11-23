using System;

class binarySearch{
    static void Main(){
        int pesquisa;
        int result;
        int [] array1 = new int[5];
        Random random = new Random();

        for(int i = 0; i < array1.Length; i++){
            array1[i] = random.Next(50);
        }
        
        //Ordena o Array
        Array.Sort(array1);

        foreach (int numero in array1){
            Console.Write(numero + " ");
        }

        Console.WriteLine("\nBinarySearch\n");
        Console.Write("Numero: ");
        pesquisa = int.Parse(Console.ReadLine());
        
        //Realiza a pesquisa
        result = Array.BinarySearch(array1, pesquisa);
        Console.Write("\nO número {0} está na posição {1} ", pesquisa, result);

    }
}