using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.CompilerServices;

namespace TrabalhandoComTasks
{
    class Program
    {
        static List<string> lista = new List<string>();
        public static void Main(string[] args)
        {
            Console.WriteLine("Inicializando a task 1...");
            Task task1 = Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    lista.Add($"X :: {i}");
                }
            });

            if (task1.IsCompleted)
            {
                Console.WriteLine("A task 1 foi encerrada...");
                ImprimeLista();
            }
            else
            {
                Console.WriteLine("A task 1 ainda está processando...");
                ImprimeLista();
                task1.Wait();
            }

            Task task2 = new Task(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    lista.Add($"X :: {i}");
                }
            });
            Console.WriteLine("Inicializando a task 2...");
            task2.RunSynchronously();
            Console.WriteLine("A task 2 foi encerrada...");
            ImprimeLista();

            Task<string> task3 = Task.Run<string>(() =>
            {
                return string.Format($"Task -> {Thread.CurrentThread.ManagedThreadId }");
            });

            Console.WriteLine(string.Format("Resultado da task 3: " + task3.Result));

            Task<int> task4 = Task.Run<int>(() =>
            {
                int result = 0;
                for (int i = 0; i < 10; i++)
                {
                    result += i;
                }
                return result;
            });
            TaskAwaiter<int> awaiter = task4.GetAwaiter();
            awaiter.OnCompleted(() =>
            {
                int resultadoTarefa = awaiter.GetResult();
                Console.WriteLine("Resultado do retorno da tarefa: " + resultadoTarefa);
            });
            Task<string> continuacao = Task.Run<string>(() =>
            {
                return string.Format("O resultado da task anterior é " + awaiter.GetResult());
            });
            Console.WriteLine(continuacao.Result);
            Console.WriteLine("A task 4 foi desperada. Esperando o resultado...");

            Console.ReadKey();
        }

        private static void ImprimeLista()
        {
            foreach (string s in lista)
            {
                Console.WriteLine(s);
            }
        }
    }
}
