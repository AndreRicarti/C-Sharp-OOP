using System;

namespace POO
{
    public class Relatorio
    {
        public decimal SaldoGeral { get; private set; }

        public void Somar(Conta conta)
        {
            this.SaldoGeral += conta.Saldo;
        }

        // Polimorfismo de Método
        public void SomarValor(decimal valor1)
        {
            this.SaldoGeral += valor1;
        }

        // Polimorfismo de Método
        public void SomarValor(decimal valor1, decimal valor2)
        {
            this.SaldoGeral += (valor1 + valor2);
        }
    }
}
