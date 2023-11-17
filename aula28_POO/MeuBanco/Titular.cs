class Titular : Conta
 {
    public String nome;
    public String rg;
    public String cpf;
    public String telefone;
    public String email;
    public String profissao;
    public double salario;
    public Conta conta;
    

    public Titular(String nome, String rg, String cpf, String telefone, String email, String profissao, double salario)
    {
        this.nome = nome;
        this.rg = rg;
        this.cpf = cpf;
        this.telefone = telefone;
        this.email = email;
        this.profissao = profissao;
        this.salario = salario;
        this.conta = new Conta();
    }   

    //Imprime os dados do titular
    public Object[] dadosTitular()
    {
        Object[] dados = new Object[8];
        dados[0] = this.nome;
        dados[1] = this.rg;
        dados[2] = this.cpf;
        dados[3] = this.telefone;
        dados[4] = this.email;
        dados[5] = this.profissao;
        dados[6] = this.salario;
        dados[7] = this.conta.numeroConta;
        
        String[] legendaDados = {
            "Nome", "Rg", "CPF", "Telefone", "Email", "Profissão", "Salário R$", "Numero da Conta" 
        };

       
        for(int i = 0; i < dados.Length; i++)
        {
            Console.WriteLine($"{legendaDados[i]}: {dados[i]}");
        }
       Console.WriteLine(); //pula linha
        return dados;
    }
}