using System;

class Veiculo
{
    //Método principal
    virtual public void info(){}
}

class Carro:Veiculo
{
    //Método sobrescrito
    override public void info()
    {
        Console.WriteLine("Informações sobre o carro 1");
    }    
}

class Carro2:Veiculo
{
    //Método sobrescrito
    override public void info()
    {
        Console.WriteLine("Informações sobre o carro 2");
    }    
}
