using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncActions
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Trabalhando com delegates
            ExecutorCalculos<decimal> ec = new ExecutorCalculos<decimal>(new Program().Multiplicar);
            ec(1.2M, 10M);

            //Utilizando Funcs
            Func<decimal, decimal, decimal> exD = new Func<decimal, decimal, decimal>(new Program().Multiplicar);
            exD(10M, 1.3M);

            Func<double, double, string> exS = new Func<double, double, string>(new Program().RetornaResultadoString);
            string textoResultado = exS(1.2, 12.4);
            Console.WriteLine(textoResultado);

            //Utilizando Actions
            Action a1 = new Program().ImprimeQualquerCoisa;
            Action<string> a2 = new Program().TesteAction;

            a1();
            a2(exS(1.3, 1.15));

            Console.ReadKey();
        }

        public delegate T ExecutorCalculos<T>(T a, T b);
        public int Somar(int num1, int num2) 
        {
            Console.WriteLine(string.Format("Resultado ({0} + {1}): {2}", num1, num2, (num1 + num2)));
            return num1 + num2;
        }

        public double Subtrair(double num1, double num2)
        {
            Console.WriteLine($"Resultado ({num1} - {num2}: {(num1 - num2)}");
            return num1 - num2;
        }

        public decimal Multiplicar(decimal num1, decimal num2)
        {
            Console.WriteLine($"Resultado ({num1} * {num2}): {(num1 * num2)}");
            return num1 * num2;
        }

        public string RetornaResultadoString(double num1, double num2)
        {
            return string.Format($"O resultado da operação ({num1} + {num2}) é {num1 + num2}");
        }

        public void TesteAction(string resultadoOperacao)
        {
            Console.WriteLine(resultadoOperacao);
        }

        public void ImprimeQualquerCoisa()
        {
            Console.WriteLine("Meu nome é Wellington Junior Nora");
        }
    }
}
