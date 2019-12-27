using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace MeusTestes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Arvore de expressao 
            ParameterExpression pe = Expression.Parameter(typeof(int), "num");
            ConstantExpression ce = Expression.Constant(5, typeof(int));
            BinaryExpression be = Expression.LessThan(ce, pe);

            Expression<Func<int, bool>> lambda1 = Expression.Lambda<Func<int, bool>>(be, new ParameterExpression[] { pe });

            Func<int, bool> result = lambda1.Compile();

            bool teste = result(10);

            Console.WriteLine(teste);

            //Utiliza lambda no delegate com uma função anônima
            Func<int, int, double> teste1 = (num1, num2) => Math.Pow(num1, num2);
            Func<int, string> teste2 = num1 => num1 > 10 ? "O número é maior que 10" : "O número é menor do que 10";

            Console.WriteLine($"Resultado da exponenciação: {teste1(2, 5)}");
            Console.WriteLine(teste2(9));

            Action<int, int> act = (num1, num2) =>
            {
                double result = Math.Pow(num1, num2);
                Console.WriteLine(string.Format("Resultado: {0}", result));
            };
            act(10, 10);
            
            Console.ReadKey();
        }

        
        
    }
}
