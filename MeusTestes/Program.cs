using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusTestes
{
    public class Program
    {
        public void Main(string[] args)
        {

            int soma1 = Soma(2, 2);
            int subtrair1 = Subtrair(4, 1);
            int dividir1 = Dividir(3, 1);
            int multiplicar1 = Multiplicar(2, 2);

            var executar = new MeusDelegates.ExecutarCalculo(Soma);
            int somar2 = executar(2, 2);

            executar = new MeusDelegates.ExecutarCalculo(Subtrair);
            int subtrair2 = executar(2, 2);

            executar = new MeusDelegates.ExecutarCalculo(Dividir);
            int dividir2 = executar(2, 2);

            executar = new MeusDelegates.ExecutarCalculo(Multiplicar);
            int multiplicar2 = executar(2, 2);

            Console.WriteLine("Resultado Soma1 : " + soma1);
            Console.WriteLine("Resultado Subtrair1 : " + subtrair1);
            Console.WriteLine("Resultado Dividir1 : " + dividir1);
            Console.WriteLine("Resultado Multiplicar1 : " + multiplicar1);

            Console.WriteLine("\n\n");

            Console.WriteLine("Resultado Soma1 : " + somar2);
            Console.WriteLine("Resultado Subtrair1 : " + subtrair2);
            Console.WriteLine("Resultado Dividir1 : " + dividir2);
            Console.WriteLine("Resultado Multiplicar1 : " + multiplicar2);

            Console.ReadKey();


        }

        public int Soma(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }
        
    }
}
