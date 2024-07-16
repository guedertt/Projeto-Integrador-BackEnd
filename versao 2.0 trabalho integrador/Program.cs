using ConsoleApp2;
using ConsoleApp3;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        bool opcoes = true;
        bool opcoes2 = true;

        while (opcoes)
        {
            Console.WriteLine("Olá professor! Digite 1 para adicionar uma nova matéria ou 2 para avaliar os alunos em sua matéria.");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Disciplinas.AdicionarMateria();
                    opcoes = false;
                    break;

                case 2:
                    Alunos.AvaliarAlunos();
                    break;
                default:
                    Console.WriteLine("Opção inválida. Digite 1 ou 2.");
                    break;
            }
        }
        while (opcoes2) { 
             Console.WriteLine("Você quer adicionar outro aluno para a mesma matéria? (1 para sim, 2 para não)");
             int input2 = int.Parse(Console.ReadLine());

            switch (input2)
            {
                case 1:
                    Alunos.AvaliarAlunos();
                    break;
                case 2:
                    Alunos.CalcularMedia();
                    break;
                default:
                    Console.WriteLine("Opção inválida. Digite 1 ou 2.");
                    break;
            }
        }     
    }
}