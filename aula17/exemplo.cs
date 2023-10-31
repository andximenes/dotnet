using System;

class exemplo{
    static void Main(){
        /* //Array
        int [] array = new int[]{1, 2, 3, 4, 5};
        for(int i = 0; i < array.Length; i++){
            Console.Write(array[i] + " ");
        }
        */

        //Matriz Bidirecional
        int [,] matriz = new int[2, 3]{{10, 20, 30}, {40, 50, 60}};

        for(int j = 0; j < matriz.GetLength(0); j++){
            for(int l = 0; l < matriz.GetLength(1); l++){
                Console.Write(matriz[j, l] + " ");
            }
            Console.WriteLine();
        }
    }
}