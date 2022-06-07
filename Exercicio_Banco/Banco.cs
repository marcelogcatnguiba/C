using System;
using System.Globalization;

namespace Exercicio_Banco
{
    internal class Banco
    {
        public int Conta { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get;private set; }

        double Taxa = 5;
        public Banco(int conta, string titular, double saldo)
        {
            Conta = conta;
            Titular = titular;
            Saldo = saldo;
        }

        public Banco(int conta, string titular)
        {
            Conta = conta;
            Titular = titular;
        }
        
        public void Deposito(double dp)
        {
            Saldo += dp;
        }
        public void Saque(double saque)
        {
            Saldo = (Saldo - saque) - Taxa;
        }
        public override string ToString()
        {
            return "Conta " + Conta + ", Titular: " + Titular + ", Saldo: " + Saldo.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
    
}
