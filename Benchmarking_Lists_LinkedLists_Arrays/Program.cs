using System.Diagnostics;
using Benchmarking_Lists_LinkedLists_Arrays.Classes;
using Benchmarking_Lists_LinkedLists_Arrays.Enums;
using Benchmarking_Lists_LinkedLists_Arrays.Metodos;
using static Benchmarking_Lists_LinkedLists_Arrays.Helpers.Common;

const bool isBenchmarkGrande = false;
int[] lengths = isBenchmarkGrande ?  new[] { 5, 5_000, 500_000, 5_000_000 } : new[] { 5, 5_000 };

MensagemInicio();
Stopwatch stopwatch = Stopwatch.StartNew();

List<Benchmark> benchmarks = new();

#region List
foreach (var length in lengths)
{
    MensagemInicio(TipoBenchmarkEnum.List, length);
    List<Usuario> obj = Lista.Inserir(benchmarks, length);
    Lista.Iterar(benchmarks, obj, length);
    Lista.AcessarAleatoriamente(benchmarks, obj, length);
    Lista.Remover(benchmarks, obj, length);
}
#endregion

#region LinkedList
foreach (var length in lengths)
{
    MensagemInicio(TipoBenchmarkEnum.LinkedList, length);
    LinkedList<Usuario> obj = ListaLigada.Inserir(benchmarks, length);
    ListaLigada.Iterar(benchmarks, obj, length);
    ListaLigada.AcessarAleatoriamente(benchmarks, obj, length);
    ListaLigada.Remover(benchmarks, obj, length);
}
#endregion

#region Array
#endregion

#region Benchmarks
NormalizarBenchmarks_ExibirMensagens(benchmarks);
#endregion

stopwatch.Stop();
MensagemFim(stopwatch);
Console.ReadKey();