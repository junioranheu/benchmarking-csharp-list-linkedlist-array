using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using Benchmarking_Lists_LinkedLists_Arrays.Classes;
using Benchmarking_Lists_LinkedLists_Arrays.Enums;

namespace Benchmarking_Lists_LinkedLists_Arrays.Helpers
{
    public static class Common
	{
        public static string ObterDescricaoEnum(Enum enumVal)
        {
            MemberInfo[] memInfo = enumVal.GetType().GetMember(enumVal.ToString());
            DescriptionAttribute? attribute = CustomAttributeExtensions.GetCustomAttribute<DescriptionAttribute>(memInfo[0]);

            return attribute!.Description;
        }

        public static void MensagemInicio(TipoBenchmarkEnum benchmark, int length)
        {
            Console.WriteLine($"Inicando novo processo [{benchmark}] {NormalizarMensagemRegistros(length)}");
        }

        public static void MensagemInicio()
        {
            Console.WriteLine($"Início do benchmarking [{DateTime.Now:dd/MM/yyyy HH:mm:ss}]\n");
        }

        public static void MensagemFim(Stopwatch stopwatch)
        {
            (double tempo, string unidade) = NormalizarElapsedMilliseconds(stopwatch.ElapsedMilliseconds);
            Console.WriteLine($"\nFim do benchmarking [{tempo} {unidade}]");
        }

        public static void NormalizarBenchmarks_ExibirMensagens(List<Benchmark> benchmarks)
        {
            Console.WriteLine("\nResultados:");
            var benchmarksAgrupado = benchmarks.GroupBy(x => new { x.TipoBenchmark, x.Acao });

            foreach (var item in benchmarksAgrupado)
            {
                TipoBenchmarkEnum tipoBenchmark = item.Select(x => x.TipoBenchmark).FirstOrDefault();
                AcaoEnum acao = item.Select(x => x.Acao).FirstOrDefault();
                List<int>? lengths = item.Select(x => x.Length).ToList();
                List<Stopwatch>? stopwatches = item.Select(x => x.Stopwatch).ToList();

                for (int i = 0; i < lengths.Count; i++)
                {
                    var (tempo, unidade) = NormalizarElapsedMilliseconds(stopwatches[i].ElapsedMilliseconds);

                    string msg = $"[{tipoBenchmark}] [{acao}] [{lengths[i]}] [{tempo} {unidade}]";
                    Console.WriteLine(msg);
                }

                Console.Write("\n");
            }
        }

        private static (double tempo, string unidade) NormalizarElapsedMilliseconds(long ms)
        {
            if (ms < 1000) {
                return (ms, "ms");
            }

            return ((ms / 1000.0), "s");
        }

        private static string NormalizarMensagemRegistros(int length)
        {
            return $"[{length} registro{(length > 1 ? "s" : string.Empty)}]"; 
        }
    }
}