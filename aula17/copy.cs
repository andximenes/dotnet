using System;

class copy{
    static void Main(){
        
        int [] array1 = new int [5];
        int [] array2 = new int [5];
        Random random = new Random();

        for(int i = 0; i < array1.Length; i++){
            array1[i] = random.Next(50);
        }
        //Ordena o Array
        Array.Sort(array1);
        //imprime os elementos do array1
        Console.Write("Array1: ");
        foreach(int num in array1){
            Console.Write(num + " ");
        }
        //Copiando Array1 para o array2
        //origem, destino, qtd elementos
        Array.Copy(array1, array2, array1.Length);
        //imprime os valores do array2
        Console.Write("\nArray2: ");
        foreach (int numero in array2){
            Console.Write(numero + " ");
        }
    }   
}