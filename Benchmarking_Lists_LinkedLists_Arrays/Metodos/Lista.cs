using System.Diagnostics;
using Benchmarking_Lists_LinkedLists_Arrays.Classes;
using Benchmarking_Lists_LinkedLists_Arrays.Enums;
using Benchmarking_Lists_LinkedLists_Arrays.Helpers;

namespace Benchmarking_Lists_LinkedLists_Arrays.Metodos
{
    public class Lista
    {
        private static readonly TipoBenchmarkEnum TipoBenchmark = TipoBenchmarkEnum.List;

        public static List<Usuario> Inserir(List<Benchmark> benchmarks, int length)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            List<Usuario> usuarios = new();

            for (int i = 0; i < length; i++)
            {
                usuarios.Add(GerarUsuario.Gerar());
            }

            stopwatch.Stop();
            GerarBenchmark.AdicionarBenchmarkEmLista(benchmarks, TipoBenchmark, AcaoEnum.Inserir, length, stopwatch);

            return usuarios;
        }

        public static void Iterar(List<Benchmark> benchmarks, List<Usuario> usuarios, int length)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
           
            for (int i = 0; i < usuarios.Count; i++)
            {
                _ = usuarios[i].Guid;
            }

            stopwatch.Stop();
            GerarBenchmark.AdicionarBenchmarkEmLista(benchmarks, TipoBenchmark, AcaoEnum.Iterar, length, stopwatch);
        }

        public static void AcessarAleatoriamente(List<Benchmark> benchmarks, List<Usuario> usuarios, int length)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            int random = GerarRandom.Int(0, usuarios.Count - 1);
            Usuario _ = usuarios[random];

            stopwatch.Stop();
            GerarBenchmark.AdicionarBenchmarkEmLista(benchmarks, TipoBenchmark, AcaoEnum.AcessarAleatoriamente, length, stopwatch);
        }

        public static void Remover(List<Benchmark> benchmarks, List<Usuario> usuarios, int length)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            int random = GerarRandom.Int(0, usuarios.Count - 1);
            usuarios.RemoveAt(random);

            stopwatch.Stop();
            GerarBenchmark.AdicionarBenchmarkEmLista(benchmarks, TipoBenchmark, AcaoEnum.Remover, length, stopwatch);
        }
    }
}