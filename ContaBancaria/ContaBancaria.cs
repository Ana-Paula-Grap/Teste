using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public class ContaBancariaC
    {
        private readonly int numeroConta;
        private string titularConta;
        private double saldo;

        public ContaBancariaC(int numeroConta, string titularConta)
        {
            this.numeroConta = numeroConta;
            this.titularConta = titularConta;
            this.saldo = 0.0;
        }

        public void Depositar(double valorDeposito)
        {
            if (valorDeposito > 0)
            {
                saldo += valorDeposito;
                Console.WriteLine($"Depósito de ${valorDeposito} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("O valor do depósito deve ser maior que zero.");
            }

            MostrarDadosConta();
        }

        public void Sacar(double valorSaque)
        {
            double taxaSaque = 3.50;

            if (saldo >= valorSaque + taxaSaque)
            {
                saldo -= (valorSaque + taxaSaque);
                Console.WriteLine($"Saque de ${valorSaque} realizado com sucesso. Taxa de ${taxaSaque} aplicada.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque.");
            }

            MostrarDadosConta();
        }

        public void MostrarDadosConta()
        {
            Console.WriteLine($"Dados da conta:\nConta {numeroConta}, Titular: {titularConta}, Saldo: ${saldo:F2}\n");
        }

        public void AlterarTitular(string novoTitular)
        {
            titularConta = novoTitular;
            Console.WriteLine($"Titular da conta alterado para: {novoTitular}");
        }
    }
}

