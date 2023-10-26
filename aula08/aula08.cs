using System;

class Aula08{
    
    static void Main(String[] args){
        String nome;
        double peso;
        double altura;
        double imc;
        double pesoIdealMin = 18.5;
        double pesoIdealMax = 24.9;

        Console.Write("Digite o Seu nome: ");
        nome = Console.ReadLine();
        Console.Write("Digite o seu peso: ");
        peso = double.Parse(Console.ReadLine());
        Console.Write("Digite sua altura: ");
        altura = double.Parse(Console.ReadLine());
        
        //calc imc
        imc = (peso / (altura * altura));
        imc = Math.Round(imc, 2);

        //calc peso ideal Mínimo e Máximo
        pesoIdealMin = (pesoIdealMin * (altura * altura));
        //pesoIdealMin = Math.Round(pesoIdealMin, 2);
        String pesoIdealMinStr = pesoIdealMin.ToString("00.00");
        pesoIdealMax = (pesoIdealMax * (altura * altura));
        //pesoIdealMax = Math.Round(pesoIdealMax, 2);
        String pesoIdealMaxStr = pesoIdealMax.ToString("00.00");

        if(imc <= 17){
            Console.WriteLine("{0}, Seu imc é {1}. Você está abaixo do peso. " +
            "Imc ideal Mínimo é {2} e o peso ideal máximo é {3}", nome, imc, pesoIdealMinStr, pesoIdealMaxStr);
        }else if(imc >= 18 && imc <=25 ){
            Console.WriteLine("{0}, Seu imc é {1}. Você está com o peso normal. " + 
            "Imc ideal Mínimo é {2} e o peso ideal máximo é {3}", nome, imc, pesoIdealMinStr, pesoIdealMaxStr);
        }else{
            Console.WriteLine("{0}, Seu imc é {1}. Você está acima do peso. " + 
            "Imc ideal Mínimo é {2} e o peso ideal máximo é {3}", nome, imc, pesoIdealMinStr, pesoIdealMaxStr);
        }
        
    }
}