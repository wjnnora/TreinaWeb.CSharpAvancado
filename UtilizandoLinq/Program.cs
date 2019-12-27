using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizandoLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Escola aluno1 = new Escola
            {
                MateriaAluno = Materia.Matematica,
                NomeAluno = "Giovane Nora",
                Nota = 7
            };

            Escola aluno2 = new Escola
            {
                MateriaAluno = Materia.Matematica,
                NomeAluno = "Wellington Nora",
                Nota = 10
            };

            Escola aluno3 = new Escola
            {
                MateriaAluno = Materia.Matematica,
                NomeAluno = "Jeferson Nora",
                Nota = 10
            };

            Escola aluno4 = new Escola
            {
                MateriaAluno = Materia.Matematica,
                NomeAluno = "Bruno Sanches",
                Nota = 3
            };

            List<Escola> notas = new List<Escola>() { aluno1, aluno2, aluno3, aluno4 };

            var resultado1 = from n in notas where n.NomeAluno.EndsWith("Nora") select new { NotaPersonalizada = (n.Nota * 10), NomePersonalizado = (n.NomeAluno.Replace(" ", "-")) };
        
            notas = notas.OrderByDescending(x => x.Nota).ThenBy(x => x.NomeAluno).ToList();
            Escola resultado2 = notas[0];
            foreach (var resultado in resultado1)
            {
                Console.WriteLine(resultado.NotaPersonalizada);
                Console.WriteLine(resultado.NomePersonalizado);
            }

            Console.WriteLine("Resultado 2: " + resultado2.NomeAluno);

            Console.ReadKey();
        }
    }

    public class Escola
    {
        public string NomeAluno { get; set; }
        public int Nota { get; set; }
        public Materia MateriaAluno { get; set; }

    }

    public enum Materia
    {
        Portugues = 1,
        Matematica = 2,
        Historia = 3,
        Geografia = 4,
        Ciencias = 5,
        Quimica = 6,
        Ingles = 7
    }
}
