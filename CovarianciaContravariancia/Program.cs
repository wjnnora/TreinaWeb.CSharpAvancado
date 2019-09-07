using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianciaContravariancia
{
    public class Program
    {
        static void Main(string []args)
        {
            ManipuladorFTP<string> manipuladorFTP = new ManipuladorFTP<string>();
            manipuladorFTP.Armazenador("wellington_nora94@hotmail.com");
            manipuladorFTP.Armazenador("welintonnora@gmail.com");

            Console.WriteLine(manipuladorFTP.Recuperador(1));

            Console.ReadKey();

            Object pessoa = new 
            {
                Nome = "Wellington Junior Nora",
                Idade = 24
            };

            var nome = pessoa.GetType().GetProperty("Nome") != null ? pessoa.GetType().GetProperty("Nome").GetValue(pessoa, null) : "";
            var idade = pessoa.GetType().GetProperty("Idade") != null ? pessoa.GetType().GetProperty("Idade").GetValue(pessoa, null) : "";

            Console.WriteLine($"O Sr. {nome} tem {idade} de idade");
            Console.ReadKey();
        }
    }
}
