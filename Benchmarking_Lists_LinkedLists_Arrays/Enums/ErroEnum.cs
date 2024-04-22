using System.ComponentModel;

namespace Benchmarking_Lists_LinkedLists_Arrays.Enums
{
    public enum ErroEnum
    {
        [Description("Indíce fora do range.")]
        IndiceForaRange,

        [Description("O item referente à esse indíce não foi encontrado na lista ligada em questão.")]
        IndiceNaoEncontrado
    }
}