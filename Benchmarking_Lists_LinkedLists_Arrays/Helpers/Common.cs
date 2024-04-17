using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
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

        public static void MensagemInicio(BenchmarkEnum benchmark)
        {
            Console.WriteLine($"Início. [{benchmark}]");
        }

        public static void MensagemStopwatch(AcaoEnum acao, Stopwatch stopwatch)
        {
            Console.WriteLine($"{ObterDescricaoEnum(acao)}: {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}