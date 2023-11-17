class Testes
{
	static void Main()
	{
		Carro carro = new Carro("BMW", "branco");
		carro.setLigar(true);
		Console.WriteLine($"{carro.getLigar()}");
		Console.WriteLine();
		Console.WriteLine($"Nome: {carro.nome}");
		Console.WriteLine($"Cor: {carro.cor}");
		Console.WriteLine($"Rodas: {carro.velMax} km/h");
		Console.WriteLine($"Qtd Rodas: {carro.getNumRodas()}");
		
		CarroCombate carroCombate = new CarroCombate();
		carroCombate.setLigar(true);
		Console.WriteLine($"{carroCombate.getLigar()}");
		Console.WriteLine();
		Console.WriteLine($"Nome: {carroCombate.nome}");
		Console.WriteLine($"Cor: {carroCombate.cor}");
		Console.WriteLine($"Qtd Munição: {carroCombate.municao}");
		Console.WriteLine($"Rodas: {carroCombate.velMax} km/h");
		Console.WriteLine($"Qtd Rodas: {carroCombate.getNumRodas()}");
			
	}
}
