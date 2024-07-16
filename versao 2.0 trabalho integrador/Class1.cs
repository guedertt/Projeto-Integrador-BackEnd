using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Disciplinas
    {
        #region atribuitos
        public string Nome { get; set; }
        public List<Avaliação> Avaliacoes { get; set; }
        #endregion
        public static void AdicionarMateria()
        {
            Disciplinas nova_materia = new Disciplinas();

            Console.WriteLine("Digite o nome da matéria:");
            nova_materia.Nome = Console.ReadLine();
            Alunos.AvaliarAlunos();
        }
    }
}