using System;

class Numero
{
    private int[] listaNum = new int[4]{50, 20, 3, 12};

    public int this[int i]{
        get
        {
            return listaNum[i];
        }
        set{
            listaNum[i] = value;
        }
    }
}