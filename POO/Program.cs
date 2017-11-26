using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente = new ContaCorrente();
            ContaPoupanca contaPoupanca = new ContaPoupanca();

            contaCorrente.Saldo = 1000;
            contaPoupanca.Saldo = 1000;

            contaCorrente.Sacar(200);
            contaPoupanca.Sacar(200);

            Console.WriteLine(contaCorrente.Saldo);
            Console.WriteLine(contaPoupanca.Saldo);

            Console.Read();
        }
    }
}
