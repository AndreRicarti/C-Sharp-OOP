using System;

namespace POO
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca() : base(500)
        {
        }

        public override void Depositar(decimal valor)
        {
            base.Saldo += valor;
        }
    }
}
