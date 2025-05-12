
namespace ContaCorrente1.ConsoleApp
{
    
    public class ContaCorrente
    {
        
        public int numero;
        public decimal saldo;
        public decimal limite;
        public Movimentacao[] movimentacoes;
        int contadorMovimentacoes = 0;

        
        public void Sacar(decimal quantia)
        {
            if (quantia <= saldo + limite)
            {
                saldo -= quantia;

                Movimentacao novaMovimentacao = new Movimentacao();
                novaMovimentacao.valor = quantia;
                novaMovimentacao.tipo = "Débito";

                movimentacoes[contadorMovimentacoes] = novaMovimentacao;
                contadorMovimentacoes++;
            }
        }

        public void Depositar(decimal quantia)
        {
            saldo += quantia;

            Movimentacao novaMovimentacao = new Movimentacao();
            novaMovimentacao.valor = quantia;
            novaMovimentacao.tipo = "Crédito";

            movimentacoes[contadorMovimentacoes] = novaMovimentacao;
            contadorMovimentacoes++;
        }

        public void TransferirPara(ContaCorrente destinatario, decimal quantia)
        {
            destinatario.Depositar(quantia);

            this.Sacar(quantia);
        }

        public void ExibirExtrato()
        {
            Console.WriteLine("Extrato da Conta #" + this.numero);

            Console.WriteLine("Saldo: " + this.saldo);

            Console.WriteLine();

            for (int i = 0; i < movimentacoes.Length; i++)
            {
                Movimentacao movimentacaoAtual = movimentacoes[i];

                if (movimentacaoAtual != null)
                {
                    Console.WriteLine(movimentacaoAtual.LerMovimentacao());
                }
            }
        }
    }
}