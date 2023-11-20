using System;

public interface Veiculo
{
    void ligar();
    void desligar();
    void info();
}

public interface Combate
{
    void disparar();
}

class Carro: Veiculo, Combate // Carro herda interface veiculo e combate
{
    public bool ligado;
    public bool desligado;
    public int municao;

    public Carro()
    {

    }

    public void ligar()
    {
        this.ligado = true;
    }
    public void desligar()
    {
        this.desligado = fase;
    }
    public void info()
    {

    }
    public void disparar()
    {
        this.municao = 100;
    }

}