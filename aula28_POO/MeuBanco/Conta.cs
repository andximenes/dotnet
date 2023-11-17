using System;
using System.Collections.Generic;

class Conta
{
    public int numeroConta;
    public int agencia;
    protected double saldo;
    public static List<int>contasCriadas = new List<int>();

    public Conta()
    {   
        //gera um número de conta atomaticamente
        Random random = new Random();
        this.numeroConta = random.Next(1000, 5000);
        //Estabelece uma agencia fixa
        this.agencia = 3590;
        //Saldo
        this.saldo = 0;
        //Adciona cada nova conta para uma lista de contas criadas
        contasCriadas.Add(numeroConta);
    }
    
    public double getSaldo()
    {   
        return this.saldo;
    }

    public void setSaldo(double valor)
    {
        this.saldo = valor;
    }

    //Imprime uma lista com as contas criadas
     public static void Lista()
     {
        Console.Write($"Contas Criadas: ");
        foreach (int qtdContas in contasCriadas){
            Console.Write(qtdContas + " ");
        }
        Console.WriteLine();
    }

    //Deposita
    public double Deposita(double valor)
    {   
        if(valor <= 0)
        {
            Console.WriteLine("Operação inválida");
            return saldo;
        }else
        {
            this.saldo += valor;
            return saldo;
        }      
    }
    //Saca
    public double Saca(double valor)
    {
        if(this.saldo < valor)
        {
            Console.WriteLine($"Saldo insuficiente!");
            return saldo;
        }else
        {
            this.saldo -= valor;
            return saldo;
        }
    }

    //Transfere
    public bool Transfere(Conta contaDestino, double valor) // contaDestido refere-se ao objeto que contem o numero da conta destino, por exemplo "Titular2"
    {
        // Verifica se a conta de destino existe na lista de contas criadas
        if(contasCriadas.Contains(contaDestino.numeroConta))
        {
            if(this.saldo >= valor)
            {
                this.Saca(valor); // Retira o valor da conta de origem
                contaDestino.Deposita(valor); // Deposita o valor na conta de destino
                return true;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para transferência!");
                return false;
            }
        }
        else
        {
            Console.WriteLine("Conta de destino não encontrada!");
            return false;
        }
    }

    
}
   





