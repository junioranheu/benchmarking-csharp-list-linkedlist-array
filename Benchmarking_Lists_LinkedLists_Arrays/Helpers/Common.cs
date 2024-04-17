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
            Console.WriteLine($"\nFim do benchmarking [{tempo} {unidade}] [{Assembly.GetEntryAssembly()!.GetName().Name}]");
        }

        public static void MensagemStopwatch(Benchmark benchmark, bool isExibirMensagemRegistros = true)
        {
            (double tempo, string unidade) = NormalizarElapsedMilliseconds(benchmark.Stopwatch.ElapsedMilliseconds);
            string mensagemRegistros = isExibirMensagemRegistros ? NormalizarMensagemRegistros(benchmark.Length) : string.Empty;

            Console.WriteLine($"{ObterDescricaoEnum(benchmark.Acao)} {mensagemRegistros}:\n{tempo} {unidade}\n");
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