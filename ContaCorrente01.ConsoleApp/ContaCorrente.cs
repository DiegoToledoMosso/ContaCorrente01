

namespace ContaCorrente01.ConsoleApp
{
    public class ContaCorrente
    {

        //Aqui iremos colocar todas os metodos e declarar suas funçoes.


        public double saldo;
        public int numero;
        public int limite;

        public Movimentacao[] movimentacoes;

        public void Sacar(double quantia)
        {
            double novoSaldo = saldo - quantia;

            saldo = novoSaldo;

            Movimentacao movimentacao = new Movimentacao();
            movimentacao.valor = quantia;
            movimentacao.tipo = "Débito";
            movimentacao.descricao = "Débito de R$" + quantia + " reais";

            int posicaoVazia = PegaPosicaoVazia();

            movimentacoes[posicaoVazia] = movimentacao;

        }

        public void Depositar(double quantia)
        {
            double novoSaldo = saldo + quantia;

            saldo = novoSaldo;

            Movimentacao movimentacao = new Movimentacao();
            movimentacao.valor = quantia;
            movimentacao.tipo = "Crédito";
            movimentacao.descricao = "Crédito de R$" + quantia + " reais";

            int posicaoVazia = PegaPosicaoVazia();

            movimentacoes[posicaoVazia] = movimentacao;

        }

        public void TransferirPara(ContaCorrente contaDestino, double quantia)
        {
            this.Sacar(quantia);

            contaDestino.Depositar(quantia);
        }

        public void ExibirExtrato()
        {
            Console.WriteLine("Numero da conta {0}", numero);

            Console.WriteLine("Movimentações: ");

            foreach (Movimentacao movimentacao in movimentacoes)
            {
                if (movimentacao != null)
                    Console.WriteLine(movimentacao.descricao);
            }

            Console.WriteLine("Saldo atual: {0}", saldo + limite);
        }

        public int PegaPosicaoVazia()
        {
            for (int i = 0; i < movimentacoes.Length; i++)
            {
                if (movimentacoes[i] == null)
                    return i;
            }

            return -1;
        }









    }
}
