using System.ComponentModel;
using System.Reflection;

namespace Benchmarking_Lists_LinkedLists_Arrays.Helpers
{
    public static class Common
	{
        /// <summary>
        /// Obtém a descrição de um enum;
        /// </summary>
        public static string ObterDescricaoEnum(Enum enumVal)
        {
            MemberInfo[] memInfo = enumVal.GetType().GetMember(enumVal.ToString());
            DescriptionAttribute? attribute = CustomAttributeExtensions.GetCustomAttribute<DescriptionAttribute>(memInfo[0]);

            return attribute!.Description;
        }
    }
}