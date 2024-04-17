using Benchmarking_Lists_LinkedLists_Arrays.Classes;
using Benchmarking_Lists_LinkedLists_Arrays.Metodos;

// In most cases, List<T> is more useful.
// LinkedList<T> will have less cost when adding/removing items in the middle of the list, whereas List<T> can only cheaply add/remove at the end of the list.
// LinkedList<T> is only at it's most efficient if you are accessing sequential data (either forwards or backwards) - random access is relatively expensive since it must walk the chain each time (hence why it doesn't have an indexer). However, because a List<T> is essentially just an array (with a wrapper) random access is fine.

const int qtdInserir = 1000;

#region List
List<Usuario> lista = Lista.Inserir(qtdInserir);
Lista.Iterar(lista);
Lista.AcessarAleatoriamente(lista);
Lista.Remover(lista);
#endregion

Console.WriteLine($"Fim. [{System.Reflection.Assembly.GetEntryAssembly()!.GetName().Name}]");
Console.ReadKey();