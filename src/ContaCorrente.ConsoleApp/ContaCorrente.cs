namespace ContaCorrente.ConsoleApp
{
    public class ContaCorrente
    {
        //atributos da conta
        public decimal saldo;
        public decimal aux = 0;

        //atributos usuario
        public Cliente titular = new Cliente();

        //atributos extrato
        private Movimentacao[] historico = new Movimentacao[50];
        private int contadorMovimentacoes = 0; 

        public Movimentacao[] Extrato()
        {
            return historico;    
        }

        public void Deposito(decimal valor)
        {
            saldo += valor;
            Movimentacao movi = new Movimentacao();
            movi.valor = valor;
            movi.tipo = "Depósito";
            historico[contadorMovimentacoes] = movi;
            contadorMovimentacoes++;
        }

        public void Saque(decimal valor)
        {
            if (valor > saldo)
            {
                Console.WriteLine($"Não é possivel sacar pois o valor exede o saldo.");

            }
            else
            {
                saldo -= valor;
                Movimentacao movi = new Movimentacao();
                movi.valor = valor;
                movi.tipo = "saque";
                historico[contadorMovimentacoes] = movi;
                contadorMovimentacoes++;
            }
        }

        public void Tranferencia(decimal valor, ContaCorrente contaDestino)
        {
            if (valor > saldo)
            {
                Console.WriteLine($"Não é possivel Tranferir pois o valor exede o saldo.");

            }
            else
            {
                saldo -= valor;
                contaDestino.RecebeTransferencia(valor);
                Movimentacao movi = new Movimentacao();
                movi.valor = valor;
                movi.tipo = "Saque";
                historico[contadorMovimentacoes] = movi;
                contadorMovimentacoes++;
            }
        }

        public void RecebeTransferencia(decimal valor)
        {
            saldo += valor;
            Movimentacao movi = new Movimentacao();
            movi.valor = valor;
            movi.tipo = "Depósito";
            historico[contadorMovimentacoes] = movi;
            contadorMovimentacoes++;
        }
    }
}