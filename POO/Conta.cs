using System;

namespace POO
{
    public class Conta
    {
        int agencia;
        int numeroConta;
        decimal saldo;
        decimal limite;


        public int Agencia
        {
            get { return Agencia1; }
            set
            {
                if (value > 0)
                {
                    Agencia1 = value;
                }
            }
        }

        public int Agencia1 { get => agencia; set => agencia = value; }
        public int NumeroConta { get => numeroConta; set => numeroConta = value; }
        public decimal Saldo { get => saldo; set => saldo = value; }
        public decimal Limite { get => limite; set => limite = value; }

        public Conta()
        {
            this.limite = 1000;
        }

        public Conta(decimal limite)
        {
            this.limite = limite;
        }

        public void SetAgencia(int agencia)
        {
            this.Agencia1 = agencia;
        }

        public virtual void Sacar(decimal valor)
        {
            Saldo -= valor;
        }

        void Depositar(decimal valor)
        {
            Saldo += valor;
        }
    }
}
