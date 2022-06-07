using System;
using System.Globalization;

namespace Exercicio_Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o numero da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Hávera deposito inicial (s/n): ");
            string inicial = Console.ReadLine();

            Banco b = new Banco(conta, titular);

            if (inicial == "s")
            {
                Console.Write("Entre com o valor do deposito: ");
                double dp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                b.Deposito(dp);
                Console.WriteLine("Dados da conta: ");
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine("Dados da conta: ");
                Console.WriteLine(b);
            }

            
            Console.Write("Entre com valor para deposito: ");
            double dpp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b.Deposito(dpp);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(b);
            Console.Write("Entre com valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b.Saque(saque);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(b);
            
        }
    }
}
