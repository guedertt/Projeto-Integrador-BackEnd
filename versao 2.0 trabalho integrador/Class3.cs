using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Alunos
    {
        public List<Disciplinas> disciplinas { get; set; }

        public List<Avaliação> Nota { get; set; }
        public string Nome { get; set; }

        public static void AvaliarAlunos()
        {
            Alunos novo_aluno = new Alunos();

            Console.WriteLine("Qual o nome do aluno que você quer atribuir a nota?");
            novo_aluno.Nome = Console.ReadLine();

            Console.WriteLine("Qual foi a nota do aluno?");
            novo_aluno.Nota.Add() = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual foi o peso da avaliação?");
            novo_aluno.Peso = int.Parse(Console.ReadLine());

            Console.WriteLine($"Avaliação de '{novo_aluno.Nome}' teve a nota {novo_aluno.Nota}.");
        }
        public static double CalcularMedia()
        {
            double somaNotas = 0;
            int somaPesos = 0;

            foreach (var disciplina in Disciplinas)
            {
                foreach (var avaliacao in disciplina.Avaliacoes)
                {
                    somaNotas += avaliacao.Nota * avaliacao.Peso;
                    somaPesos += avaliacao.Peso;
                }
            }

            return somaPesos > 0 ? somaNotas / somaPesos : 0;
        }
    }
}

