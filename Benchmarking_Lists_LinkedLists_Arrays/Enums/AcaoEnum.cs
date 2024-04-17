using System.ComponentModel;

namespace Benchmarking_Lists_LinkedLists_Arrays.Enums
{
    public enum AcaoEnum
    {
        [Description("foi inserido")]
        Inserir,

        [Description("foi iterado")]
        Iterar,

        [Description("foi acessado aleatoriamente")]
        AcessarAleatoriamente,

        [Description("foi removido")]
        Remover
    }
}