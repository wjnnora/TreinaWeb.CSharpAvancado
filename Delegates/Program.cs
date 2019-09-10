using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        delegate void ExibeMensagem(int idade);
        static ExibeMensagem exibeMensagem;
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o sexo: ");
            string sexo = Console.ReadLine();
            Console.WriteLine("Digite a idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            if (sexo.ToUpper() == "HOMEM")
            {
                exibeMensagem = MensagemHomemCarregarPeso;
                exibeMensagem += MensagemHomemCrescer;
            }
            else
            {
                exibeMensagem = MensagemMulherCarregarPeso;
                exibeMensagem += MensagemMulherCrescer;
            }

            exibeMensagem(idade);

            Console.ReadKey();
        }

        //Mensagens para homens
        static void MensagemHomemCarregarPeso(int idade)
        {
            if (idade > 22)
                Console.WriteLine("Você já pode carregar bastante peso");
            else
                Console.WriteLine("Você não pode carregar muito peso");
        }

        static void MensagemHomemCrescer(int idade)
        {
            if (idade > 18)
                Console.WriteLine("Você já cresceu o suficiente");
            else
                Console.WriteLine("Você ainda crescerá mais");
        }

        //Mensagens para Mulheres
        static void MensagemMulherCarregarPeso(int idade)
        {
            if (idade > 22)
                Console.WriteLine("Você já pode carregar bastante peso");
            else
                Console.WriteLine("Você não pode carregar muito peso");
        }

        static void MensagemMulherCrescer(int idade)
        {
            if (idade > 18)
                Console.WriteLine("Você já cresceu o suficiente");
            else
                Console.WriteLine("Você ainda crescerá mais");
        }
    }
}
