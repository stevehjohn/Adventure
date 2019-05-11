using System.Text;

namespace AdventureEngine.Extensions
{
    public static class StringExtensions
    {
        public static string RemovePunctuation(this string text)
        {
            var builder = new StringBuilder();

            foreach (var character in text)
            {
                if (! char.IsPunctuation(character))
                {
                    builder.Append(character);
                }
            }

            return builder.ToString();
        }
    }
}