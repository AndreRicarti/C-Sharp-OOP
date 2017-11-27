using System;

namespace POO
{
    class MinhaExcecao : Exception
    {
        public Exception MensagemErro(string msg)
        {
            return new Exception(msg);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 0;

                if(b == 0)
                {
                    throw new MinhaExcecao().MensagemErro("Erro lançado.");
                }

                int resultado = a / b;

                Console.WriteLine(resultado);

                int[] vetor = new int[] { 1, 2, 3 };
                Console.WriteLine(vetor[0]);
            }
            catch (System.DivideByZeroException ex)
            {
                //Console.WriteLine(ex.Message);
                //Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Erro: Divisão por zero");
            }
            catch (System.IndexOutOfRangeException ex)
            {
                Console.WriteLine("Erro: Fora do indice da coleção!!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Fim da Execução");
            }

            Console.Read();

            //ContaCorrente contaCorrente = new ContaCorrente();
            //ContaPoupanca contaPoupanca = new ContaPoupanca();

            //contaCorrente.Depositar(1000);
            //contaPoupanca.Depositar(1000);

            //contaCorrente.Sacar(200);
            //contaPoupanca.Sacar(200);

            //Console.WriteLine(contaCorrente.Saldo);
            //Console.WriteLine(contaPoupanca.Saldo);

            //Relatorio relatorio = new Relatorio();
            //relatorio.Somar(contaCorrente);
            //relatorio.Somar(contaPoupanca);

            //relatorio.SomarTributos(contaPoupanca);

            //Console.WriteLine(relatorio.SaldoGeral);
            //Console.WriteLine(relatorio.TributoGeral);

            //Console.Read();
        }
    }
}
