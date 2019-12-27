using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDeExtensao
{
    class Program
    {
        static void Main(string[] args)
        {
            string meuNome = "Wellington Junior Nora";
            int[] ints = new int[] { 1, 10, 2, 9, 5, 6 };
            string[] strings = new string[] { "Nora", "Junior", "Nora", "Animal" };


            var resultInt = ints.OrderBy(g => g);
            var resultString = strings.OrderBy(x => x);

            Console.WriteLine(meuNome.AplicaEspaco());

            Console.WriteLine(resultInt);

            Console.ReadKey();
        }
    }
}
