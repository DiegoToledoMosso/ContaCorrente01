namespace ContaCorrente01.ConsoleApp
{
    internal class Program
    {
        /*Versão 01
         * Criar uma conta corrente com as seguintes funcionalidades:
         * Saldo = sacar depositar
         * Numero da conta
         * limete da conta
         * movimentação
         * transferencia entre contas
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a sua conta corrente.");

            //Iremos trabalhar agora na conta 01

            //Criar uma conta corrente
            ContaCorrente conta1 = new ContaCorrente();
            //saldo
            conta1.saldo = 1000;
            //numero da conta
            conta1.numero = 12;
            //limete da conta
            conta1.limete = 0;
            //movimentação contendo apenas 10
            conta1.movimentacoes = new Movimentacao[10];

            //Iremos inserir os comando de sacar e depositar em metodos

            conta1.Sacar(200);

            conta1.Depositar(300);

            conta1.Depositar(500);

            conta1.Sacar(200);

            //Iremos trabalhar agora na conta 02

            ContaCorrente conta2 = new ContaCorrente();
            conta2.saldo = 1000;
            conta2.numero = 12;
            conta2.limite = 0;
            conta2.movimentacoes = new Movimentacao[10];

            //Comando transferir
            conta1.TransferirPara(conta2, 400);


            conta1.ExibirExtrato();









        }
    }
}
