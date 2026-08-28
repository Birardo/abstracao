using System.Security.Cryptography.X509Certificates;

namespace abstracao
{
    public class Aluno
    {
        public string Nome;
        public int Matricula;
        public double Nota1;
        public double Nota2;
        double Media;

        public void CalcularMedia()
        {
            Media = (Nota1 + Nota2)/2;

        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"O aluno {Nome} de matrícula {Matricula} ficou com a média final de {Media:F2}");
            Console.WriteLine("-------------------------");
        }
    }
}
