using Benchmarking_Lists_LinkedLists_Arrays.Classes;
using Benchmarking_Lists_LinkedLists_Arrays.Enums;
using static Benchmarking_Lists_LinkedLists_Arrays.Helpers.Common;

namespace Benchmarking_Lists_LinkedLists_Arrays.Helpers
{
    public class GerarUsuario
	{
        public static Usuario Gerar()
		{
            Usuario usuario = new()
            {
                Guid = GerarRandom.UUID(),
                Nome = GerarRandom.String(10),
                Sobrenome = GerarRandom.String(20),
                Idade = GerarRandom.Int(1, 100),
                Sexo = GerarRandom.Sexo(),
                Cidade = GerarCidade.Gerar()
            };

            return usuario;
        }

        public static void Mensagem(Usuario? usuario, AcaoEnum acao, int index = 0, bool isExibir = true)
        {
            if (!isExibir)
            {
                return;
            }

            if (usuario is null)
            {
                Console.WriteLine($"O usuário de index {index} {ObterDescricaoEnum(acao)}");
                return;
            }

            Console.WriteLine($"O usuário {usuario.Nome} ({usuario.Guid}) {ObterDescricaoEnum(acao)}");
        }
    }
}