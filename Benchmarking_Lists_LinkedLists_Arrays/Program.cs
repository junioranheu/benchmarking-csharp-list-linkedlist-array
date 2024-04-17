using Benchmarking_Lists_LinkedLists_Arrays.Classes;
using Benchmarking_Lists_LinkedLists_Arrays.Enums;
using Benchmarking_Lists_LinkedLists_Arrays.Metodos;
using static Benchmarking_Lists_LinkedLists_Arrays.Helpers.Common;

const int length = 5_000_000;

#region List
MensagemInicio(BenchmarkEnum.List, length);
List<Usuario> lista = Lista.Inserir(length);
Lista.Iterar(lista);
Lista.AcessarAleatoriamente(lista);
Lista.Remover(lista);
#endregion

MensagemFim();
Console.ReadKey();