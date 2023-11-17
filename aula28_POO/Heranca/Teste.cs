using System;

class Veiculo
{	
	public int velMax;
 	
 	private int rodas;
 
	private bool ligado;
	
	public Veiculo(int rodas)
	{
		this.rodas = rodas;
	}
	
	public void setLigar(bool ligado)
	{
		this.ligado = ligado;
	}
	
	public string getLigar()
	{
		return this.ligado == true? "Carro Ligado!": "O carro desligado";
	}
	
	public int getNumRodas()
	{
		return this.rodas;
	}
	
	public void setRodas(int numRodas)
	{
		if(rodas < 0)
		{
			this.rodas = 0;
		}else if(rodas > 10)
		{
			this.rodas = 10;
		}else
		{
			this.rodas = numRodas;
		}
			
	}
		
}

class Carro : Veiculo
{
	public string nome;
	public string cor;
	
	public Carro(string nome, string cor): base(4) 
	{
		setLigar(false);
		//rodas = 4; parametro 6 ref a carga do construtor Veiculo
		velMax = 120;
		this.nome = nome;
		this.cor = cor;
	}

}

class CarroCombate:Carro
{
	public int municao;
	
	public CarroCombate():base("Carro de combate", "Verde")
	{
		municao = 100;
		setRodas(6);
	}
}

