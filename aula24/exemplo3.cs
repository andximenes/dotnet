  using System;

  class exemplo3{
    static void Main(){
         soma(5, 10, 15, 20, 80);
    }

    static void soma(params int[] nums){
        int resultado =  0;
        if(nums.Length < 1){
            Console.WriteLine("Não existe valores a serem somados");
        }else if(nums.Length < 2){
            Console.WriteLine("Valor insuficiente para soma");
        } else{
            for(int i = 0; i < nums.Length; i++){
                resultado += nums[i]; 
            }
            Console.WriteLine("A soma dos valores é: {0}", resultado);
        }
    }
  }