namespace abstracao
{
    internal class ContaBancaria
    {
        public string Titular;
        public int NumeroConta;
        public double Saldo;


        public double Depositar(double valorRecebido)
        {
            return Saldo += valorRecebido;
        }
        public void Sacar(double valorSacado)
        {
            if (Saldo >= valorSacado)
            {
                double Sacado = Saldo -= valorSacado;
                Console.WriteLine($"Seu saldo após o saque é: {Sacado}");
            }

            else
               Console.WriteLine("Valor insuficiente");
        }
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Saldo: {Saldo}");
            Console.WriteLine("-------------------------");
        }
    }
}
