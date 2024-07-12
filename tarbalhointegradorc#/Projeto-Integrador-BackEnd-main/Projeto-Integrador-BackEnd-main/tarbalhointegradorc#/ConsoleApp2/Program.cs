using ConsoleApp2;

internal class Program
{
    private static void Main(string[] args)

    {


        bool opcoes = false;  
        bool nomealuno = false;


        Console.WriteLine("Olá professor!, digite 1 para adicionar uma nova matéria ou digite 2 para avaliar os alunos em sua matéria.");

        int input = int.Parse(Console.ReadLine());

        switch (input)
        {
            case 1:
                opcoes = true;
                break;
            case 2:             
                break;
        }

        string escolha;
        Disciplinas nova_materia = new Disciplinas();
        Avaliação nova_ava = new Avaliação();
        Avaliação novo_aluno = new Avaliação();
        while (opcoes == true)
        {
            

            Console.WriteLine("escreva o nome da matéria");
            nova_materia.Nome = Console.ReadLine();

            for (int quantidade = 0; quantidade <= 6; quantidade++)
                {
                if (quantidade > 6) 
                { 
                    nomealuno = true;
                    opcoes = false;

                }    
                Console.WriteLine($"qual o peso da avaliação de {nova_materia.Nome} (1,2,3 ou 4?)");
                nova_ava.Peso = int.Parse(Console.ReadLine());

                if (nova_ava.Peso != 1 && nova_ava.Peso != 2 && nova_ava.Peso != 3 && nova_ava.Peso != 4 )
                {
                    Console.WriteLine("digite um numero válido");
                    break;
                }                       

                Console.WriteLine("voce quer digitar uma nova avaliação para a materia? (s/n)");
                escolha = Console.ReadLine().ToLower();


                if (escolha == "s")
                {
                    
                    opcoes = false;                   
                    nomealuno = false;
                }
                else if (escolha == "n")
                {                  
                    opcoes = false;                   
                    quantidade = 7;
                    nomealuno = true;
                }
                else
                {
                    Console.WriteLine("digite s ou n");
                   
                }
                if (nomealuno == true)
                {
                    Console.WriteLine("Qual o nome do aluno que você quer atribuir a nota?");
                    novo_aluno.AlunoNome = Console.ReadLine();
                    {
                        
                        Console.WriteLine($"qual foi a nota do {novo_aluno.AlunoNome}");
                        nova_ava.Nota = int.Parse(Console.ReadLine());
                    }


                }
            }
            
        }
        
    }
}
