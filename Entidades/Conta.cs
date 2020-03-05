using System;

namespace aula_solid_04_03_2020.Entidades
{
    public abstract class Conta
    {
        public Pessoa Pessoa { get; protected set; } 
        public decimal Saldo { get; protected set; }

        public Conta(Pessoa pessoa)
        {
            Pessoa = pessoa;
            Saldo = 0.0m;
        }

        public abstract void Saque(decimal valor);
        public abstract void Deposito(decimal valor);

        public void GetSaldo()
            => Console.WriteLine($"{Pessoa.nome} seu saldo é de {Saldo}");

    }
}