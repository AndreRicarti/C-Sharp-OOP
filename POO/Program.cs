using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente = new ContaCorrente();
            ContaPoupanca contaPoupanca = new ContaPoupanca();

            contaCorrente.Depositar(1000);
            contaPoupanca.Depositar(1000);

            contaCorrente.Sacar(200);
            contaPoupanca.Sacar(200);

            Console.WriteLine(contaCorrente.Saldo);
            Console.WriteLine(contaPoupanca.Saldo);

            Relatorio relatorio = new Relatorio();
            relatorio.Somar(contaCorrente);
            relatorio.Somar(contaPoupanca);

            relatorio.SomarValor(10);
            relatorio.SomarValor(10, 20);

            Console.WriteLine(relatorio.SaldoGeral);

            Console.Read();
        }
    }
}
