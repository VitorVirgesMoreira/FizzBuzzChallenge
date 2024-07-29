using TwistedFizzBuzz;

var tokens = new Dictionary<int, string>
{
    { 5, "Fizz" },
    { 9, "Buzz" },
    { 27, "Bar" }
};

var results = FizzBuzzGenerator.Generate(-20, 127, tokens);

foreach (var result in results)
{
    Console.WriteLine(result);
}