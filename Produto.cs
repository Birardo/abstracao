namespace abstracao
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int QuantidadeEstoque;

        public void ExibirInformacoesProduto()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Preço : {Preco}\nQuantidade no estoque: {QuantidadeEstoque}");
            Console.WriteLine("-------------------------");
        }
    }
}
