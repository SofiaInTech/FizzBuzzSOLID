// See https://aka.ms/new-console-template for more information
Console.WriteLine("Fizz Buzz SOLID");
Console.WriteLine("----------------------");

// TODO: Register FizzBuzzService here via DI.

var range = Enumerable.Range(1, 99);

foreach (int number in range) {
    Console.WriteLine(number);
}

