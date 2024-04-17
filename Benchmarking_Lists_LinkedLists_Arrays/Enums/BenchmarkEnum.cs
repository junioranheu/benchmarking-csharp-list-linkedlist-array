﻿using System.ComponentModel;

namespace Benchmarking_Lists_LinkedLists_Arrays.Enums
{
    // Ward:
    // In most cases, List<T> is more useful.
    // LinkedList<T> will have less cost when adding/removing items in the middle of the list, whereas List<T> can only cheaply add/remove at the end of the list.
    // LinkedList<T> is only at it's most efficient if you are accessing sequential data (either forwards or backwards) - random access is relatively expensive since it must walk the chain each time (hence why it doesn't have an indexer). However, because a List<T> is essentially just an array (with a wrapper) random access is fine.

    public enum BenchmarkEnum
    {
        [Description("Representa uma lista, uma coleção ordenada de elementos com acesso rápido por índice.")]
        List,

        [Description("Refere-se a uma lista encadeada, onde cada elemento contém uma referência para o próximo elemento na sequência.")]
        LinkedList,

        [Description("Representa uma estrutura de dados de arranjo unidimensional com tamanho fixo, onde os elementos são acessados por um índice.")]
        Array
    }
}