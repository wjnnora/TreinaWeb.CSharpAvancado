using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threads
{
    class Program
    {
        static List<string> lista = new List<string>();
        static object obj = new object();
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(Thread1);
            thread1.Name = "Thread X";
            thread1.IsBackground = true;
            thread1.Priority = ThreadPriority.Lowest;
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("pt-BR");

            Thread thread2 = new Thread(Thread2);
            thread2.Name = "Thread Y";
            thread2.IsBackground = false;
            thread2.Priority = ThreadPriority.Highest;
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();

            foreach (var c in lista)
            {
                Console.WriteLine(c);
            }

            string texto = "O número passado é o {0}";
            int num = 10;

            Thread threadTeste = new Thread(() => ThreadTeste(num, texto));
            threadTeste.Name = "Thread de teste";
            threadTeste.Start();
            threadTeste.Join();

            Console.ReadKey();


        }

        public static void Thread1()
        {
            lock (obj)
            {
                for (int i = 0; i < 6; i++)
                {
                    lista.Add($"{DateTime.Now} - {Thread.CurrentThread.Name} {i} ");
                    Thread.Sleep(500);
                }
            }

        }

        public static void Thread2()
        {
            lock (obj)
            {
                for (int i = 0; i < 4; i++)
                {
                    lista.Add($"{DateTime.Now} - {Thread.CurrentThread.Name} {i}");
                    Thread.Sleep(500);
                }
            }

        }

        public static void ThreadTeste(int num, string texto)
        {
            Console.WriteLine(Thread.CurrentThread.Name + " " + string.Format(texto, num));
        }
    }
}
