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
}