using System;

class CalcArea
{
    public static float Quad(float bas, float alt)
    {
        if(bas == 0 || alt == 0)
        {
            throw new Exception("Nenhum dos campos podem ser igual a 0");
        }

        return bas * alt;
    }

}

class Teste
{
   static void Main()
   {
        float area = 0;
        
        try
        {
            area = CalcArea.Quad(2f, 4f);
            Console.WriteLine($"Area do Quarado {area}");
        }catch(Exception e)
        {
            Console.WriteLine($"Erro: {e.Message}");
        }
        finally
        {
            Console.WriteLine("Fim do processo");
        }

   }
}