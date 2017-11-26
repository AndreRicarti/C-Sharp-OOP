using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente = new ContaCorrente();
            Console.WriteLine(contaCorrente.TaxaMovimento);
            Console.WriteLine(contaCorrente.Limite);

            ContaPoupanca contaPoupanca = new ContaPoupanca();
            Console.WriteLine(contaPoupanca.Limite);

            Console.Read();
        }
    }
}
