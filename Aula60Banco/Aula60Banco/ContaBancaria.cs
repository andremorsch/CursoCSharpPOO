using System;
using System.Collections.Generic;
using System.Text;

namespace Aula60Banco
{
    internal class ContaBancaria
    {
        public int Conta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int conta, string nome, double saldo)
        {
            Conta = conta;
            Nome = nome;
            Deposito(saldo);
        }

        public override string ToString()
        {
            return $"Conta: {Conta}, Titular: {Nome}, Saldo ${Saldo.ToString("F2")}"; 
        }

        public void Deposito(double val)
        {
            Saldo += val;
        }

        public void Saque(double val)
        {
            Saldo -= (val + 5.00);
        }
    }
}
