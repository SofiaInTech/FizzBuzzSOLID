using FizzBuzzSOLID;
using FizzBuzzSOLID.Service;
using FizzBuzzSOLID.Service.Interfaces;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Fizz Buzz SOLID");
Console.WriteLine("----------------------");

// Register FizzBuzzService
var services = new ServiceCollection().AddSingleton<IFizzBuzzService>(new FizzBuzzService());

using (var serviceProvider = services.BuildServiceProvider())
{
    // Hand FizzBuzzService over to FizzBuzzFunctions.Output() to output result as required.
    var fizzBuzzService = serviceProvider.GetService<IFizzBuzzService>();
    FizzBuzzFunctions.Output(fizzBuzzService);
}
