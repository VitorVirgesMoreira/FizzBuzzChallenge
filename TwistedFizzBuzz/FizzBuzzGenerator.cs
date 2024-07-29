namespace TwistedFizzBuzz
{
    public class FizzBuzzGenerator
    {
        public static List<string> Generate(int start, int end, Dictionary<int, string> tokens)
        {
            var result = new List<string>();

            for (int i = start; i <= end; i++)
            {
                result.Add(GenerateFizzBuzz(i, tokens));
            }

            return result;
        }

        public static List<string> Generate(IEnumerable<int> numbers, Dictionary<int, string> tokens)
        {
            var result = new List<string>();

            foreach (var number in numbers)
            {
                result.Add(GenerateFizzBuzz(number, tokens));
            }

            return result;
        }

        private static string GenerateFizzBuzz(int number, Dictionary<int, string> tokens)
        {
            var result = string.Empty;

            foreach (var token in tokens)
            {
                if (number % token.Key == 0)
                {
                    result += token.Value;
                }
            }

            return string.IsNullOrEmpty(result) ? number.ToString() : result;
        }
    }
}