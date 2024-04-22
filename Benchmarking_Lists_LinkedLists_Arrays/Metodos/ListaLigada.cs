using System.Diagnostics;
using Benchmarking_Lists_LinkedLists_Arrays.Classes;
using Benchmarking_Lists_LinkedLists_Arrays.Enums;
using Benchmarking_Lists_LinkedLists_Arrays.Helpers;

namespace Benchmarking_Lists_LinkedLists_Arrays.Metodos
{
    public class ListaLigada
	{
        private static readonly TipoBenchmarkEnum TipoBenchmark = TipoBenchmarkEnum.LinkedList;

        public static LinkedList<Usuario> Inserir(List<Benchmark> benchmarks, int length)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            LinkedList<Usuario> usuarios = new();

            for (int i = 0; i < length; i++)
            {
                usuarios.AddLast(GerarUsuario.Gerar());
            }

            stopwatch.Stop();
            GerarBenchmark.AdicionarBenchmarkEmLista(benchmarks, TipoBenchmark, AcaoEnum.Inserir, length, stopwatch);

            return usuarios;
        }

        public static void Iterar(List<Benchmark> benchmarks, LinkedList<Usuario> usuarios, int length)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            for (int i = 0; i < usuarios.Count; i++)
            {
                _ = ObterObjetoPorIndice(usuarios, i).Guid;
            }

            stopwatch.Stop();
            GerarBenchmark.AdicionarBenchmarkEmLista(benchmarks, TipoBenchmark, AcaoEnum.Iterar, length, stopwatch);
        }

        public static void AcessarAleatoriamente(List<Benchmark> benchmarks, LinkedList<Usuario> usuarios, int length)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            int random = GerarRandom.Int(0, usuarios.Count - 1);
            Usuario _ = ObterObjetoPorIndice(usuarios, random);

            stopwatch.Stop();
            GerarBenchmark.AdicionarBenchmarkEmLista(benchmarks, TipoBenchmark, AcaoEnum.AcessarAleatoriamente, length, stopwatch);
        }

        public static void Remover(List<Benchmark> benchmarks, LinkedList<Usuario> usuarios, int length)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            int random = GerarRandom.Int(0, usuarios.Count - 1);
            RemoverObjetoPorIndice(usuarios, random);

            stopwatch.Stop();
            GerarBenchmark.AdicionarBenchmarkEmLista(benchmarks, TipoBenchmark, AcaoEnum.Remover, length, stopwatch);
        }

        private const string ErroIndiceForaRange = "Indíce fora do range.";
        private const string ErroIndiceNaoEncontrado = "O item referente à esse indíce não foi encontrado na lista ligada em questão.";

        private static T ObterObjetoPorIndice<T>(LinkedList<T> linkedList, int index)
        {
            if (index < 0 || index >= linkedList.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), ErroIndiceForaRange);
            }

            int currentIndex = 0;

            foreach (var item in linkedList)
            {
                if (currentIndex == index)
                {
                    return item;
                }

                currentIndex++;
            }

            throw new InvalidOperationException(ErroIndiceNaoEncontrado);
        }

        private static void RemoverObjetoPorIndice<T>(LinkedList<T> linkedList, int index)
        {
            if (index < 0 || index >= linkedList.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), ErroIndiceForaRange);
            }

            LinkedListNode<T> currentNode = linkedList.First!;
            int currentIndex = 0;

            while (currentNode != null)
            {
                if (currentIndex == index)
                {
                    linkedList.Remove(currentNode);
                    return;
                }

                currentNode = currentNode.Next!;
                currentIndex++;
            }

            throw new InvalidOperationException(ErroIndiceNaoEncontrado);
        }
    }
}