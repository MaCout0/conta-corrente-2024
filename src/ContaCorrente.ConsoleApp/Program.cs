namespace ContaCorrente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaFulano = new ContaCorrente();

            ContaCorrente contaBeltrano = new ContaCorrente();

            Movimentacao[] historico = new Movimentacao[0];

            contaFulano.titular.nome = "Fulano";
            contaFulano.titular.sobreNome = "Detal";
            contaFulano.titular.CPF = "123.456.789-10";
            contaFulano.saldo = 2000;

            contaBeltrano.titular.nome = "Beltrano";
            contaBeltrano.titular.sobreNome = "Detal";
            contaBeltrano.titular.CPF = "123.456.789-10";
            contaBeltrano.saldo = 1000;

            Console.WriteLine($"Saldo atual: {contaFulano.saldo}");
            Console.WriteLine($"Saldo atual: {contaBeltrano.saldo}");
            Console.ReadLine();

            //Console.Clear();
            Console.WriteLine("Teste deposito de 300");
            contaFulano.Deposito(300);
            Console.WriteLine($"Saldo atual: {contaFulano.saldo}");
            Console.WriteLine($"Saldo atual: {contaBeltrano.saldo}");
            Console.ReadLine();

            //Console.Clear();
            Console.WriteLine("Teste saque de 500");
            contaFulano.Saque(500);
            Console.WriteLine($"Saldo atual: {contaFulano.saldo}");
            Console.WriteLine($"Saldo atual: {contaBeltrano.saldo}");
            Console.ReadLine();

            //Console.Clear();
            Console.WriteLine("Teste saque de 5000");
            contaFulano.Saque(5000);
            Console.WriteLine($"Saldo atual: {contaFulano.saldo}");
            Console.WriteLine($"Saldo atual: {contaBeltrano.saldo}");
            Console.ReadLine();

            //Console.Clear();
            Console.WriteLine("Teste transferência de 300");
            contaFulano.Tranferencia(300, contaBeltrano);
            Console.WriteLine($"Saldo atual: {contaFulano.saldo}");
            Console.WriteLine($"Saldo atual: {contaBeltrano.saldo}");
            Console.ReadLine();

            //Console.Clear();
            Console.WriteLine("Teste transferência de 3000");
            contaFulano.Tranferencia(3000, contaBeltrano);
            Console.WriteLine($"Saldo atual: {contaFulano.saldo}");
            Console.WriteLine($"Saldo atual: {contaBeltrano.saldo}");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Estrato conta Funlano");
            historico = contaFulano.Extrato();
            for(int i = 0; i < historico.Length; i++)
            {
                Movimentacao movimentacao = historico[i];
                if (movimentacao != null)
                    Console.WriteLine($"{movimentacao.tipo} {movimentacao.valor}");
            }
            Console.WriteLine("");
            Console.WriteLine("Estrato conta Beltrano");
            historico = contaBeltrano.Extrato();
            for (int i = 0; i < historico.Length; i++)
            {
                Movimentacao movimentacao = historico[i];
                if (movimentacao != null)
                    Console.WriteLine($"{movimentacao.tipo} {movimentacao.valor}");
            }

            Console.ReadLine();
        }
    }
}