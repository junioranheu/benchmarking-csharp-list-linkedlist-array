using System.Diagnostics;
using Benchmarking_Lists_LinkedLists_Arrays.Classes;
using Benchmarking_Lists_LinkedLists_Arrays.Enums;
using Benchmarking_Lists_LinkedLists_Arrays.Helpers;
using static Benchmarking_Lists_LinkedLists_Arrays.Helpers.Common;

namespace Benchmarking_Lists_LinkedLists_Arrays.Metodos
{
    public class Lista
    {
        public static List<Usuario> Inserir(int length)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            List<Usuario> usuarios = new();

            for (int i = 0; i < length; i++)
            {
                usuarios.Add(GerarUsuario.Gerar());
            }

            stopwatch.Stop();
            MensagemStopwatch(AcaoEnum.Inserir, stopwatch);

            return usuarios;
        }

        public static void Iterar(List<Usuario> usuarios)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            for (int i = 0; i < usuarios.Count; i++)
            {
                _ = usuarios[i].Guid;
            }

            stopwatch.Stop();
            MensagemStopwatch(AcaoEnum.Iterar, stopwatch);
        }

        public static void AcessarAleatoriamente(List<Usuario> usuarios)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            int random = GerarRandom.Int(0, usuarios.Count - 1);
            Usuario _ = usuarios[random];

            stopwatch.Stop();
            MensagemStopwatch(AcaoEnum.AcessarAleatoriamente, stopwatch);
        }

        public static void Remover(List<Usuario> usuarios)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            int random = GerarRandom.Int(0, usuarios.Count - 1);
            usuarios.RemoveAt(random);

            stopwatch.Stop();
            MensagemStopwatch(AcaoEnum.Remover, stopwatch);
        }
    }
}