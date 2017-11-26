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

            relatorio.SomarTributos(contaPoupanca);

            Console.WriteLine(relatorio.SaldoGeral);
            Console.WriteLine(relatorio.TributoGeral);

            Console.Read();
        }
    }
}
