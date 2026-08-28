namespace abstracao
{
    public class Carro
    {
        //atributos (características)
        public string Marca;
        public string Modelo;
        public int Ano;
        public string Cor;

        //metodos (comportamento)
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Carro : {Marca} {Modelo}");
            Console.WriteLine($"Cor : {Cor}, Ano: {Ano}");
            Console.WriteLine("-------------------------");
        }



    }
}
