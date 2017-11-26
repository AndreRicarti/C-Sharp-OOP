using System;

namespace POO
{
    public abstract class Conta
    {
        int agencia;
        int numeroConta;
        decimal saldo;
        decimal limite;


        public int Agencia
        {
            get { return Agencia; }
            set
            {
                if (value > 0)
                {
                    Agencia = value;
                }
            }
        }

        public int NumeroConta { get => numeroConta; private set => numeroConta = value; }
        // protected pode trabalhar no método set na mesma classe ou em classes que herdam.
        public decimal Saldo { get => saldo; protected set => saldo = value; }
        public decimal Limite { get => limite; private set => limite = value; }

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
            this.Agencia = agencia;
        }

        public virtual void Sacar(decimal valor)
        {
            Saldo -= valor;
        }

        public abstract void Depositar(decimal valor);
    }
}
