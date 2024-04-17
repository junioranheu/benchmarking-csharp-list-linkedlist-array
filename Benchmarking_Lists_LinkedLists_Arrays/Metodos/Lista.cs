using Benchmarking_Lists_LinkedLists_Arrays.Classes;
using Benchmarking_Lists_LinkedLists_Arrays.Helpers;

namespace Benchmarking_Lists_LinkedLists_Arrays.Metodos
{
    public class Lista
	{
        public static List<Usuario> GerarLista(int length)
		{
            List<Usuario> usuarios = new();

            for (int i = 0; i < length; i++)
            {
                usuarios.Add(GerarUsuario.Gerar());
            }

            return usuarios;
        }
	}
}