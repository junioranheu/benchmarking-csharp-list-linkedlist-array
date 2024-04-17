using Benchmarking_Lists_LinkedLists_Arrays.Classes;
using Benchmarking_Lists_LinkedLists_Arrays.Enums;
using Benchmarking_Lists_LinkedLists_Arrays.Helpers;

namespace Benchmarking_Lists_LinkedLists_Arrays.Metodos
{
    public class Lista
    {
        public static List<Usuario> Inserir(int length, bool isExibirMensagem = false)
        {
            List<Usuario> usuarios = new();

            for (int i = 0; i < length; i++)
            {
                Usuario usuario = GerarUsuario.Gerar();
                GerarUsuario.Mensagem(usuario, acao: AcaoEnum.Inserir, isExibir: isExibirMensagem);

                usuarios.Add(usuario);
            }

            return usuarios;
        }

        public static void Iterar(List<Usuario> usuarios, bool isExibirMensagem = false)
        {
            for (int i = 0; i < usuarios.Count; i++)
            {
                GerarUsuario.Mensagem(usuarios[i], acao: AcaoEnum.Iterar, isExibir: isExibirMensagem);
            }
        }

        public static void AcessarAleatoriamente(List<Usuario> usuarios, bool isExibirMensagem = false)
        {
            int random = GerarRandom.Int(0, usuarios.Count);
            Usuario usuario = usuarios[random];

            GerarUsuario.Mensagem(usuario, acao: AcaoEnum.AcessarAleatoriamente, isExibir: isExibirMensagem);
        }

        public static void Remover(List<Usuario> usuarios, bool isExibirMensagem = false)
        {
            int random = GerarRandom.Int(0, usuarios.Count);
            usuarios.RemoveAt(random);

            GerarUsuario.Mensagem(usuario: null, acao: AcaoEnum.AcessarAleatoriamente, index: random, isExibir: isExibirMensagem);
        }
    }
}