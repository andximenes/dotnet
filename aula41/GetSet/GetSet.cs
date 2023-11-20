using System;

class Carro
{
    private int velMax;

    public int vm
    {
        get
        {
            return velMax;
        }
        set
        {
            if(value < 0)
            {
                velMax = 0;
            }else if(value > 300)
            {
                velMax = 300;
            }else
            {
                velMax = value;
            }
        }
    }
    
    public Carro()
    {
        vm = 120;
    }

}