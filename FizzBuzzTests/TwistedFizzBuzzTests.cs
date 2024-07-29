using TwistedFizzBuzz;

namespace FizzBuzzTests
{
    public class TwistedFizzBuzzTests
    {
        [Fact]
        public void Should_Generate_Range1To15_WithStandardTokens()
        {
            var tokens = new Dictionary<int, string>
            {
                { 3, "Fizz" },
                { 5, "Buzz" }
            };

            var expected = new List<string>
            {
                "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"
            };

            var result = FizzBuzzGenerator.Generate(1, 15, tokens);

            result.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Should_Generate_NonSequential_WithStandardTokens()
        {
            var tokens = new Dictionary<int, string>
            {
                { 3, "Fizz" },
                { 5, "Buzz" }
            };

            var input = new List<int> { -5, 6, 300, 12, 15 };
            var expected = new List<string> { "Buzz", "Fizz", "FizzBuzz", "Fizz", "FizzBuzz" };

            var result = FizzBuzzGenerator.Generate(input, tokens);

            result.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Should_Generate_Range1To15_WithCustomTokens()
        {
            var tokens = new Dictionary<int, string>
            {
                { 7, "Poem" },
                { 17, "Writer" },
                { 3, "College" }
            };

            var expected = new List<string>
            {
                "1", "2", "College", "4", "5", "College", "Poem", "8", "College", "10", "11", "College", "13", "Poem", "College"
            };

            var result = FizzBuzzGenerator.Generate(1, 15, tokens);

            result.Should().BeEquivalentTo(expected);
        }
    }
}