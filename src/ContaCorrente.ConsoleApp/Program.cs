namespace ContaCorrente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaFulano = new ContaCorrente();

            ContaCorrente contaBeltrano = new ContaCorrente();

            contaFulano.titular.nome = "Fulano";
            contaFulano.titular.sobreNome = "Detal";
            contaFulano.titular.CPF = "123.456.789-10";
            contaFulano.saldo = 2000;

            contaBeltrano.titular.nome = "Beltrano";
            contaBeltrano.titular.sobreNome = "Detal";
            contaBeltrano.titular.CPF = "123.456.789-10";
            contaBeltrano.saldo = 500;

            Console.WriteLine($"Saldo atual: {contaFulano.saldo}");
            Console.ReadLine();

            //Console.Clear();
            Console.WriteLine("Teste deposito de 300");
            contaFulano.valor = 300;
            contaFulano.Deposito();
            Console.WriteLine($"Saldo atual: {contaFulano.saldo}");
            Console.ReadLine();

            //Console.Clear();
            Console.WriteLine("Teste saque de 500");
            contaFulano.valor = 500;
            contaFulano.Saque();
            Console.WriteLine($"Saldo atual: {contaFulano.saldo}");
            Console.ReadLine();

            //Console.Clear();
            Console.WriteLine("Teste saque de 5000");
            contaFulano.valor = 5000;
            contaFulano.Saque();
            Console.WriteLine($"Saldo atual: {contaFulano.saldo}");
            Console.ReadLine();

            //Console.Clear();
            Console.WriteLine("Teste transferência de 300");
            contaFulano.valor = 300;
            contaFulano.Tranferencia();
            Console.WriteLine($"Saldo atual: {contaFulano.saldo}");
            Console.ReadLine();

            //Console.Clear();
            Console.WriteLine("Teste transferência de 3000");
            contaFulano.valor = 3000;
            contaFulano.Tranferencia();
            Console.WriteLine($"Saldo atual: {contaFulano.saldo}");
            Console.ReadLine();



            Console.ReadLine();

        }

    }

    public class Cliente
    {
        //atributos
        public string nome;
        public string sobreNome;
        public string CPF;
    }

    public class Movimentacao
    {
        public decimal valor;
        public string tipo;
    }

    public class ContaCorrente
    {
        //atributos da conta
        public decimal saldo;
        public decimal aux = 0;
        public decimal valor;


        //atributos usuario
        public Cliente titular = new Cliente();

        //atributos extrato
        public Movimentacao[] historico = new Movimentacao[50];

        public void Deposito()
        {
            saldo += valor;
        }

        public void Saque()
        {
            if (valor > saldo)
            {
                Console.WriteLine($"Não é possivel sacar pois o valor exede o saldo.");

            }
            else
            {
                saldo -= valor;
            }
        }

        public void Tranferencia()
        {
            if (valor > saldo)
            {
                Console.WriteLine($"Não é possivel Tranferir pois o valor exede o saldo.");

            }
            else
            {
                saldo -= valor;
            }
        }
    }
}