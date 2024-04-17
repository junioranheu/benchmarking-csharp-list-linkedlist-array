using Benchmarking_Lists_LinkedLists_Arrays.Classes;

namespace Benchmarking_Lists_LinkedLists_Arrays.Helpers
{
    public class GerarUsuario
	{
        public static Usuario Gerar()
		{
            Usuario usuario = new()
            {
                Nome = GerarRandom.String(10),
                Sobrenome = GerarRandom.String(10),
                Idade = GerarRandom.Int(1, 100),
                Sexo = GerarRandom.Sexo(),
                Cidade = GerarCidade.Gerar()
            };

            return usuario;
        }
	}
}