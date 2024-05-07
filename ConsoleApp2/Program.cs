using System;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre com o número da conta: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.Write("Entre com o nome do titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)?: ");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 's' || resposta  == 'S')
            {
                Console.Write("Entre com o valor do depósito inicial: $");
                double depositoInicial = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(conta);
        }
    }
}
