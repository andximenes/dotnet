using System;

class exemplo2{
    static void Main(){
        double km;
        double tempo;

        Console.Write("Distãncia a ser percorrida: ");
        km = double.Parse(Console.ReadLine());
        Console.Write("Em quanto tempo deseja percorrer todo o trajeto: ");
        tempo = double.Parse(Console.ReadLine());

        Console.WriteLine("Você precisa percorrer o trajeto em uma velocidade média de {0}km/h", calcVelocidade(km, tempo));
        Console.WriteLine();
    }

    static double calcVelocidade(double k, double t){
        t = t / 60;
        double velMedia = k / t;
        return velMedia;
    }
}