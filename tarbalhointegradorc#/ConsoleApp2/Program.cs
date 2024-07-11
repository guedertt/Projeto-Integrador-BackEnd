using ConsoleApp2;

internal class Program
{
    private static void Main(string[] args)

    {
        bool opcoes = false;

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
        while (opcoes == true)
        {
            Disciplinas nova_materia = new Disciplinas();
            Console.WriteLine("escreva o nome da matéria");
            nova_materia.Nome = Console.ReadLine();
            Console.WriteLine(nova_materia.Nome);
            Console.WriteLine("voce quer digitar uma nova materia? (s/n)");
            escolha = Console.ReadLine();

            if (escolha == "s")
            {
                continue;
            }
            else if (escolha == "n")
            {
                opcoes = false;
            }
            else
            {
                Console.WriteLine("digite s ou n");
            }
            Console.WriteLine($"qual o peso da materia {nova_materia.Nome}");
            
        }
    }
}