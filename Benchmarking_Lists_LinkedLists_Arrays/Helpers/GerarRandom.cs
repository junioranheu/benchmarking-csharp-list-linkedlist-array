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

        public static Guid UUID()
        { 
            return Guid.NewGuid();
        }

        public static string Naruto()
        {
            Random random = new();

            string[] names = new[]
            {
                "Naruto", "Sasuke", "Sakura", "Kakashi", "Itachi", "Hinata", "Jiraiya",
                "Gaara", "Shikamaru", "Tsunade", "Madara", "Obito", "Minato", "Rock Lee",
                "Neji", "Kiba", "Choji", "Ino", "Temari", "Kankuro", "Orochimaru",
                "Nagato", "Konan", "Zabuza", "Haku", "Deidara", "Kisame", "Tenten",
                "Shino", "Hashirama", "Tobirama", "Sarutobi", "Danzo", "Kabuto",
                "Karin", "Suigetsu", "Jugo", "Killer Bee", "Yamato", "Sai", "Asuma",
                "Kurama", "Kushina", "Mei Terumi", "Raikage", "Onoki", "Shizune"
            };

            string name = names[random.Next(names.Length)];

            return name;
        }
    }
}