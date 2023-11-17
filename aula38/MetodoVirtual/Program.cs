class teste
{
    static void Main()
    {
        Veiculo Ref;
        Carro carro = new Carro();
        Carro2 carro2 = new Carro2();
        
        //carro.info();
        //carro2.info();

        Ref = carro2;
        Ref.info();

        


    }
}