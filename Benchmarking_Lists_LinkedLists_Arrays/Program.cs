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

    MensagemIntermediaria(TipoBenchmarkEnum.List, AcaoEnum.Inserir);
    List<Usuario> obj = Lista.Inserir(benchmarks, length);

    MensagemIntermediaria(TipoBenchmarkEnum.List, AcaoEnum.Iterar);
    Lista.Iterar(benchmarks, obj, length);

    MensagemIntermediaria(TipoBenchmarkEnum.List, AcaoEnum.AcessarAleatoriamente);
    Lista.AcessarAleatoriamente(benchmarks, obj, length);

    MensagemIntermediaria(TipoBenchmarkEnum.List, AcaoEnum.Remover, isSkipLine: true);
    Lista.Remover(benchmarks, obj, length);
}
#endregion

#region LinkedList
foreach (var length in lengths.Where(x => x <= 5_000).ToList())
{
    MensagemInicio(TipoBenchmarkEnum.LinkedList, length);

    MensagemIntermediaria(TipoBenchmarkEnum.LinkedList, AcaoEnum.Inserir);
    LinkedList<Usuario> obj = ListaLigada.Inserir(benchmarks, length);

    MensagemIntermediaria(TipoBenchmarkEnum.LinkedList, AcaoEnum.Iterar);
    ListaLigada.Iterar(benchmarks, obj, length);

    MensagemIntermediaria(TipoBenchmarkEnum.LinkedList, AcaoEnum.AcessarAleatoriamente);
    ListaLigada.AcessarAleatoriamente(benchmarks, obj, length);

    MensagemIntermediaria(TipoBenchmarkEnum.LinkedList, AcaoEnum.Remover, isSkipLine: true);
    ListaLigada.Remover(benchmarks, obj, length);
}
#endregion

#region Array
foreach (var length in lengths)
{
    MensagemInicio(TipoBenchmarkEnum.Array, length);

    MensagemIntermediaria(TipoBenchmarkEnum.Array, AcaoEnum.Inserir);
    Usuario[] obj = Matriz.Inserir(benchmarks, length);

    MensagemIntermediaria(TipoBenchmarkEnum.Array, AcaoEnum.Iterar);
    Matriz.Iterar(benchmarks, obj, length);

    MensagemIntermediaria(TipoBenchmarkEnum.Array, AcaoEnum.AcessarAleatoriamente);
    Matriz.AcessarAleatoriamente(benchmarks, obj, length);

    MensagemIntermediaria(TipoBenchmarkEnum.Array, AcaoEnum.Remover, isSkipLine: true);
    Matriz.Remover(benchmarks, obj, length);
}
#endregion

#region Dictionary
foreach (var length in lengths)
{
    MensagemInicio(TipoBenchmarkEnum.Dictionary, length);

    MensagemIntermediaria(TipoBenchmarkEnum.Dictionary, AcaoEnum.Inserir);
    List<Usuario> obj = Lista.Inserir(benchmarks, length); // Reutilizar o método de inserção de Lista;

    MensagemIntermediaria(TipoBenchmarkEnum.Dictionary, AcaoEnum.GerarDicionario);
    Dictionary<UsuarioKey_Sexo_CidadeNome, List<Usuario>> objDicionario = Dicionario.GerarDicionario(benchmarks, obj, length);

    MensagemIntermediaria(TipoBenchmarkEnum.Dictionary, AcaoEnum.Iterar);
    Dicionario.Iterar(benchmarks, objDicionario, length);

    MensagemIntermediaria(TipoBenchmarkEnum.Dictionary, AcaoEnum.AcessarAleatoriamente);
    Dicionario.AcessarAleatoriamente(benchmarks, objDicionario, length);

    MensagemIntermediaria(TipoBenchmarkEnum.Dictionary, AcaoEnum.Remover, isSkipLine: true);
    Dicionario.Remover(benchmarks, objDicionario, length);
}
#endregion

#region Benchmarks
NormalizarBenchmarks_ExibirMensagens(benchmarks);
#endregion

stopwatch.Stop();
MensagemFim(stopwatch);
Console.ReadKey();