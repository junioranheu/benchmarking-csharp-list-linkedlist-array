using System.Diagnostics;
using Benchmarking_Lists_LinkedLists_Arrays.Classes;
using Benchmarking_Lists_LinkedLists_Arrays.Enums;
using Benchmarking_Lists_LinkedLists_Arrays.Helpers;

namespace Benchmarking_Lists_LinkedLists_Arrays.Metodos
{
    public class Dicionario
	{
        private static readonly TipoBenchmarkEnum TipoBenchmark = TipoBenchmarkEnum.Dictionary;

        public static Dictionary<UsuarioKey_Sexo_CidadeNome, List<Usuario>> GerarDicionario(List<Benchmark> benchmarks, List<Usuario> usuarios, int length)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            Dictionary<UsuarioKey_Sexo_CidadeNome, List<Usuario>> usuariosDictionary = usuarios.
            GroupBy(x => new UsuarioKey_Sexo_CidadeNome(x.Sexo, x.Cidade.Nome)).
            ToDictionary(x => x.Key, x => x.ToList());

            stopwatch.Stop();
            GerarBenchmark.AdicionarBenchmarkEmLista(benchmarks, TipoBenchmark, AcaoEnum.GerarDicionario, length, stopwatch);

            return usuariosDictionary;
        }

        public static void Iterar(List<Benchmark> benchmarks, Dictionary<UsuarioKey_Sexo_CidadeNome, List<Usuario>> usuarios, int length)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            foreach (var entry in usuarios)
            {
                UsuarioKey_Sexo_CidadeNome key = entry.Key;
                List<Usuario> userList = entry.Value;

                foreach (Usuario _ in userList)
                {
                    // Console.WriteLine($"Key: {key}, Usuario ID: {user.Guid}, Nome: {user.Nome}");
                }
            }

            stopwatch.Stop();
            GerarBenchmark.AdicionarBenchmarkEmLista(benchmarks, TipoBenchmark, AcaoEnum.Iterar, length, stopwatch);
        }

        public static void AcessarAleatoriamente(List<Benchmark> benchmarks, Dictionary<UsuarioKey_Sexo_CidadeNome, List<Usuario>> usuarios, int length)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            SexoEnum sexo = GerarRandom.Sexo();
            string naruto = GerarRandom.Naruto();

            var key = new UsuarioKey_Sexo_CidadeNome(sexo, naruto);
            usuarios.TryGetValue(key, out List<Usuario>? _);

            stopwatch.Stop();
            GerarBenchmark.AdicionarBenchmarkEmLista(benchmarks, TipoBenchmark, AcaoEnum.AcessarAleatoriamente, length, stopwatch);
        }

        public static void Remover(List<Benchmark> benchmarks, Dictionary<UsuarioKey_Sexo_CidadeNome, List<Usuario>> usuarios, int length)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            SexoEnum sexo = GerarRandom.Sexo();
            string naruto = GerarRandom.Naruto();

            var key = new UsuarioKey_Sexo_CidadeNome(sexo, naruto);
            usuarios.Remove(key);

            stopwatch.Stop();
            GerarBenchmark.AdicionarBenchmarkEmLista(benchmarks, TipoBenchmark, AcaoEnum.Remover, length, stopwatch);
        }
    }
}