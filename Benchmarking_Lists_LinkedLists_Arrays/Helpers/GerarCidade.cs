using Benchmarking_Lists_LinkedLists_Arrays.Classes;

namespace Benchmarking_Lists_LinkedLists_Arrays.Helpers
{
    public class GerarCidade
    {
        public static Cidade Gerar()
        {
            Cidade cidade = new()
            {
                Nome = GerarRandom.Naruto(),
                PopulacaoEstimada = GerarRandom.Int(1, 100000),
                IsAtivo = GerarRandom.Bool()
            };

            return cidade;
        }
    }
}