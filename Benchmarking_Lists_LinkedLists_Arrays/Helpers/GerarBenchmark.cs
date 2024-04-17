using System.Diagnostics;
using Benchmarking_Lists_LinkedLists_Arrays.Classes;
using Benchmarking_Lists_LinkedLists_Arrays.Enums;

namespace Benchmarking_Lists_LinkedLists_Arrays.Helpers
{
    public class GerarBenchmark
    {
        public static void AdicionarBenchmarkEmLista(List<Benchmark> benchmarks, TipoBenchmarkEnum tipoBenchmark, AcaoEnum acao, int length, Stopwatch stopwatch)
        {
            Benchmark benchmark = new()
            {
                Guid = GerarRandom.UUID(),
                TipoBenchmark = tipoBenchmark,
                Acao = acao,
                Length = length,
                Stopwatch = stopwatch
            };

            benchmarks.Add(benchmark);
        }
    }
}