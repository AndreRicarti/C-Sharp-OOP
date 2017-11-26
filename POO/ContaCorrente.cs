using System;

namespace POO
{
    public class ContaCorrente : Conta
    {
        private decimal taxaMovimento;

        public decimal TaxaMovimento { get => taxaMovimento; set => taxaMovimento = value; }

        // Quando se usa o base() com parâmetro, você esta chamando o construtor com parâmetro;
        public ContaCorrente() : base(3000)
        {
            this.taxaMovimento = 0.1m;
        }

        // Usando Métodos Virtuais no C#
        public override void Sacar(decimal valor)
        {
            base.Sacar(valor + (this.taxaMovimento * valor));
        }

        public override void Depositar(decimal valor)
        {
            base.Saldo += valor;
        }
    }
}
