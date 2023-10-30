using System;

class aula09{

    enum status{
        aprovado,
        recuperacao,
        reprovado
    };


    static void Main(String[]  args){
        double primeiroBim;
        double segundoBim;
        double terceiroBim;
        double quartoBimn;
        String nomeAluno;
        String [] alunos = {
            "Pedro", "João", "Maria", "Camila", "Fernado"
        };

        Console.WriteLine("Boletim {0}", Environment.NewLine);
        Console.Write("Pesquisar Aluno(a): ");
        nomeAluno = Console.ReadLine();

        
        for(int i = 0; i < alunos.Length; i++){
            if(nomeAluno == alunos[i]){
                Console.WriteLine("Aluno: " + alunos[i] + "{0}", Environment.NewLine);
                //Recebe as notas
                Console.Write("1º Bimestre: ");
                primeiroBim  = double.Parse(Console.ReadLine());
                Console.Write("2º Bimestre: ");
                segundoBim  = double.Parse(Console.ReadLine());
                Console.Write("3º Bimestre: ");
                terceiroBim  = double.Parse(Console.ReadLine());
                Console.Write("4º Bimestre: ");
                quartoBimn  = double.Parse(Console.ReadLine());
                
                //Calc média
                double media = ((primeiroBim + segundoBim + terceiroBim + quartoBimn) / 4);
                if(media < 7 && media >=  5){
                    Console.WriteLine("{0}", Environment.NewLine);
                    Console.Write("Sua média foi: {0}{1}", media, Environment.NewLine);
                    Console.WriteLine("{0}", Environment.NewLine);
                    status situacao = status.recuperacao;
                    Console.WriteLine(situacao);
                }else if(media < 5){
                    Console.WriteLine("{0}", Environment.NewLine);
                    Console.Write("Sua média foi: {0}{1}", media, Environment.NewLine);
                    Console.WriteLine("{0}", Environment.NewLine);
                    status situacao = status.reprovado;
                    Console.WriteLine(situacao);
                }else{
                    Console.WriteLine("{0}", Environment.NewLine);
                    Console.Write("Sua média foi: {0}{1}", media, Environment.NewLine);
                    Console.WriteLine("{0}", Environment.NewLine);
                    status situacao = status.aprovado;
                    Console.WriteLine(situacao);
                }
                
                break;
            }else{
                Console.WriteLine("Aluno não Existe");
                break;
            }
        }
    }
}