using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OO.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldo)
        {
            NumeroConta = numeroConta;
            Saldo = saldo;
        }
        public int NumeroConta { get; set; }

        private decimal Saldo { get; set; }

        public void Sacar(decimal valor)
        {
            if (Saldo > valor)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R$ {valor} realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Não há saldo o suficiente para sacar essa quantia!");
            }
        }
        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo disponível é de R${Saldo}");
        }
    }
}