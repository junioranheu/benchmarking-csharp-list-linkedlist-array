using System.Diagnostics;
using Benchmarking_Lists_LinkedLists_Arrays.Classes;
using Benchmarking_Lists_LinkedLists_Arrays.Enums;
using Benchmarking_Lists_LinkedLists_Arrays.Helpers;
using static Benchmarking_Lists_LinkedLists_Arrays.Helpers.Common;

namespace Benchmarking_Lists_LinkedLists_Arrays.Metodos
{
    public class Matriz
	{
        private static readonly TipoBenchmarkEnum TipoBenchmark = TipoBenchmarkEnum.Array;

        public static Usuario[] Inserir(List<Benchmark> benchmarks, int length)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Usuario[] usuarios = new Usuario[length];

            for (int i = 0; i < length; i++)
            {
                usuarios[i] = GerarUsuario.Gerar();
            }

            stopwatch.Stop();
            GerarBenchmark.AdicionarBenchmarkEmLista(benchmarks, TipoBenchmark, AcaoEnum.Inserir, length, stopwatch);

            return usuarios;
        }

        public static void Iterar(List<Benchmark> benchmarks, Usuario[] usuarios, int length)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            for (int i = 0; i < usuarios.Length; i++)
            {
                _ = usuarios[i].Guid;
            }

            stopwatch.Stop();
            GerarBenchmark.AdicionarBenchmarkEmLista(benchmarks, TipoBenchmark, AcaoEnum.Iterar, length, stopwatch);
        }

        public static void AcessarAleatoriamente(List<Benchmark> benchmarks, Usuario[] usuarios, int length)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            int random = GerarRandom.Int(0, usuarios.Length - 1);
            Usuario _ = usuarios[random];

            stopwatch.Stop();
            GerarBenchmark.AdicionarBenchmarkEmLista(benchmarks, TipoBenchmark, AcaoEnum.AcessarAleatoriamente, length, stopwatch);
        }

        public static void Remover(List<Benchmark> benchmarks, Usuario[] usuarios, int length)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            int random = GerarRandom.Int(0, usuarios.Length - 1);
            RemoverObjetoPorIndice(usuarios, random);

            stopwatch.Stop();
            GerarBenchmark.AdicionarBenchmarkEmLista(benchmarks, TipoBenchmark, AcaoEnum.Remover, length, stopwatch);
        }

        private static T[] RemoverObjetoPorIndice<T>(T[] source, int index)
        {
            ArgumentNullException.ThrowIfNull(source);

            if (index < 0 || index >= source.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(index), ObterDescricaoEnum(ErroEnum.IndiceForaRange));
            }

            T[] dest = new T[source.Length - 1];

            if (index > 0)
            { 
                Array.Copy(source, 0, dest, 0, index);
            }

            if (index < source.Length - 1)
            {
                Array.Copy(source, index + 1, dest, index, source.Length - index - 1);
            }

            return dest;
        }
    }
}