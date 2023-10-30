using System;

class Aula08{
    
    static void Main(String[] args){
        String nome;
        double peso;
        double altura;
        double imc;
        double imcMin = 18.5;
        double imcMax = 24.9;
        double ganharPeso;
        double perderPeso;
        String pesoMinStr;
        String pesoMaxStr;
        String ganharPesoStr;
        String perderPesoStr;

        Console.Write("Nome: ");
        nome = Console.ReadLine();
        Console.Write("Peso: ");
        peso = double.Parse(Console.ReadLine());
        Console.Write("Altura: ");
        altura = double.Parse(Console.ReadLine());
        
        //calc imc
        imc = (peso / (altura * altura));
        imc = Math.Round(imc, 2);

        //calc o IMC Mínimo e Máximo
        imcMin = (imcMin * (altura * altura));
        imcMax = (imcMax * (altura * altura));
        
        //calc ganho ou perda de peso
         ganharPeso = imcMax - peso;
         perderPeso = peso - imcMax;

        //Formata os valores
        pesoMinStr = imcMin.ToString("00.00");
        pesoMaxStr = imcMax.ToString("00.00");
        perderPesoStr = perderPeso.ToString("00.00");
        ganharPesoStr = ganharPeso.ToString("00.00");

        Console.WriteLine("{0}", Environment.NewLine);

        if(imc <= 17){
            Console.WriteLine("{0}, Você está abaixo do peso.{1}" + 
            "Seu IMC....................{2,15}.{1}" +
            "Peso Mínimo recomendado....{3,15} kg.{1}" +  BomBom di
            "Peso Máximo recomendado....{4,15} kg.{1}" + 
            "Você precisa de {5} Kg para obter o peso ideal", nome, Environment.NewLine, imc, pesoMinStr, pesoMaxStr, ganharPesoStr);
        }else if(imc >= 18 && imc <=25 ){
            Console.WriteLine("{0}, Seu peso está noraml.{1}" +
            "Seu IMC....................{2,15}.{1}" +
            "Peso Mínimo recomendado....{3,15} kg.{1}" + 
            "IMC Máximo recomendado.....{4,15} kg.{1}" + 
            "Você está com o peso normal", nome, Environment.NewLine, imc, pesoMinStr, pesoMaxStr);
        }else{
            Console.WriteLine("{0}, Você está acima do peso.{1}" + 
            "Seu IMC....................{2,15}.{1}" +
            "Peso Mínimo recomendado....{3,15} kg.{1}" + 
            "Peso Máximo recomendado....{4,15} kg.{1}" + 
            "Você precisa perder {5} Kg para obter o peso ideal", nome, Environment.NewLine, imc, pesoMinStr, pesoMaxStr, perderPesoStr);
        } 
         Console.WriteLine("{0}", Environment.NewLine);
    }
   
}
