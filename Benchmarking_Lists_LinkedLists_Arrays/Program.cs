using System.Diagnostics;
using Benchmarking_Lists_LinkedLists_Arrays.Classes;
using Benchmarking_Lists_LinkedLists_Arrays.Enums;
using Benchmarking_Lists_LinkedLists_Arrays.Metodos;
using static Benchmarking_Lists_LinkedLists_Arrays.Helpers.Common;

const bool isBenchmarkGrande = true;
int[] lengths = isBenchmarkGrande ?  new[] { 5, 5_000, 500_000, 5_000_000 } : new[] { 5, 5_000 };

MensagemInicio();
Stopwatch stopwatch = Stopwatch.StartNew();

List<Benchmark> benchmarks = new();

#region List
foreach (var length in lengths)
{
    MensagemInicio(TipoBenchmarkEnum.List, length);
    List<Usuario> lista = Lista.Inserir(benchmarks, length);
    Lista.Iterar(benchmarks, lista, length);
    Lista.AcessarAleatoriamente(benchmarks, lista, length);
    Lista.Remover(benchmarks, lista, length);
}
#endregion

#region Benchmarks
Console.WriteLine("\nResultados:");
foreach (var item in benchmarks)
{
    MensagemStopwatch(item);
}
#endregion

stopwatch.Stop();
MensagemFim(stopwatch);
Console.ReadKey();