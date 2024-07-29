using TwistedFizzBuzz;

var tokens = new Dictionary<int, string>
{
    { 3, "Fizz" },
    { 5, "Buzz" }
};

var results = FizzBuzzGenerator.Generate(1, 100, tokens);

foreach (var result in results)
{
    Console.WriteLine(result);
}
