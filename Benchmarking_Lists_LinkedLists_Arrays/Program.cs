using Benchmarking_Lists_LinkedLists_Arrays.Classes;
using Benchmarking_Lists_LinkedLists_Arrays.Enums;
using Benchmarking_Lists_LinkedLists_Arrays.Metodos;
using static Benchmarking_Lists_LinkedLists_Arrays.Helpers.Common;

const int qtdInserir = 1000000;

#region List
MensagemInicio(BenchmarkEnum.List);
List<Usuario> lista = Lista.Inserir(qtdInserir);
Lista.Iterar(lista);
Lista.AcessarAleatoriamente(lista);
Lista.Remover(lista);
#endregion

Console.WriteLine($"\nFim. [{System.Reflection.Assembly.GetEntryAssembly()!.GetName().Name}]");
Console.ReadKey();