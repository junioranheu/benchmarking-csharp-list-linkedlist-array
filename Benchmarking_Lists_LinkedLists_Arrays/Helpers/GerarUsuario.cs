using Benchmarking_Lists_LinkedLists_Arrays.Classes;

namespace Benchmarking_Lists_LinkedLists_Arrays.Helpers
{
    public class GerarUsuario
	{
        public static Usuario Gerar()
		{
            Usuario usuario = new()
            {
                Guid = GerarRandom.UUID(),
                Nome = GerarRandom.String(20),
                Sobrenome = GerarRandom.String(50),
                Idade = GerarRandom.Int(1, 100),
                Sexo = GerarRandom.Sexo(),
                Cidade = GerarCidade.Gerar()
            };

            return usuario;
        }
    }
}