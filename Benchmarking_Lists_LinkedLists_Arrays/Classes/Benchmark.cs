using System.Diagnostics;
using Benchmarking_Lists_LinkedLists_Arrays.Enums;

namespace Benchmarking_Lists_LinkedLists_Arrays.Classes
{
    public sealed class Benchmark
    {
        public required Guid Guid { get; set; }
        public required TipoBenchmarkEnum TipoBenchmark { get; set; }
        public required AcaoEnum Acao { get; set; }
        public required int Length { get; set; }
        public required Stopwatch Stopwatch { get; set; }
    }
}