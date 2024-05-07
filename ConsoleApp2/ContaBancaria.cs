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
        public int nConta { get; private set; }
        public string titularConta { get; set; }
        public double saldoConta { get; private set; }

        public ContaBancaria(int nConta, string titularConta)
        {
            this.nConta = nConta;
            this.titularConta = titularConta;
        }

        public ContaBancaria(int nConta, string titularConta, double saldoConta) : this(nConta, titularConta)
        {
            this.saldoConta = saldoConta;
        }

        public override string ToString()
        {
            return $"Conta: {nConta}, Titular: {titularConta}, Saldo: ${saldoConta.ToString("f2", CultureInfo.InvariantCulture)}";
        }
    }
}
