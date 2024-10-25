using Benchmarking_Lists_LinkedLists_Arrays.Enums;

namespace Benchmarking_Lists_LinkedLists_Arrays.Classes
{
    public sealed class Usuario
	{
        public required Guid Guid { get; set; }
        public required string Nome { get; set; }
        public required string Sobrenome { get; set; }
        public required int Idade { get; set; }
        public required SexoEnum Sexo { get; set; }
        public required Cidade Cidade { get; set; }
    }

    public class UsuarioKey_Sexo_CidadeNome
    {
        public SexoEnum Sexo { get; set; }
        public string CidadeNome { get; set; }

        public UsuarioKey_Sexo_CidadeNome(SexoEnum sexo, string cidadeNome)
        {
            Sexo = sexo;
            CidadeNome = cidadeNome;
        }

        public override bool Equals(object? obj)
        {
            if (obj is UsuarioKey_Sexo_CidadeNome x)
            {
                return Sexo == x.Sexo && CidadeNome == x.CidadeNome;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Sexo, CidadeNome);
        }
    }
}