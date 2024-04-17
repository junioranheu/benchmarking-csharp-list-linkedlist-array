using System.Text;
using Benchmarking_Lists_LinkedLists_Arrays.Enums;

namespace Benchmarking_Lists_LinkedLists_Arrays.Helpers
{
    public class GerarRandom
	{
        private static readonly Random random = new();

        public static string String(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder builder = new(length);

            for (int i = 0; i < length; i++)
            {
                builder.Append(chars[random.Next(chars.Length)]);
            }

            return builder.ToString();
        }

        public static int Int(int min, int max)
        {
            return random.Next(min, max + 1);
        }

        public static bool Bool()
        {
            return random.Next(2) == 0;
        }

        public static SexoEnum Sexo()
        {
            int length = Enum.GetValues(typeof(SexoEnum)).Length;
            int randomIndex = random.Next(length);

            return (SexoEnum)randomIndex;
        }
    }
}