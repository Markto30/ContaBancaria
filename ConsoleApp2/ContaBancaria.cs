using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ContaBancaria
    {
        public int NConta { get; private set; }
        public string TitularConta { get; set; }
        public double SaldoConta { get; private set; }

        public ContaBancaria(int nConta, string titularConta)
        {
            this.NConta = nConta;
            this.TitularConta = titularConta;
        }

        public ContaBancaria(int nConta, string titularConta, double saldoConta) : this(nConta, titularConta)
        {
            this.SaldoConta = saldoConta;
        }

        public void Deposito(double valorDeposito)
        {
            SaldoConta += valorDeposito; 
        }

        public void Saque(double valorSaque)
        {
            SaldoConta -= valorSaque + 5.0;
        }

        public override string ToString()
        {
            return $"Conta: {NConta}, Titular: {TitularConta}, Saldo: ${SaldoConta.ToString("f2", CultureInfo.InvariantCulture)}";
        }
    }
}
