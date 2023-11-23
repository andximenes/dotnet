using System;

class Galinha
{
    private string nomeGalinha;
    private int numOvo;

    public Galinha(string nomeGalinha)
    {
        this.nomeGalinha = nomeGalinha;
        this.numOvo = 0;
    }

    //Método que retorna um objeto
    public Ovo botar()
    {
        this.numOvo++;
        return new Ovo(numOvo, nomeGalinha);
    }
}

class Ovo
{
    private int numOvo;
    private string minhaGalinha;

    public Ovo(int numOvo, string minhaGalinha)
    {
        this.minhaGalinha = minhaGalinha;
        this.numOvo = numOvo;
        Console.WriteLine($"Ovo criado: {this.numOvo} - {this.minhaGalinha}");
    }
}