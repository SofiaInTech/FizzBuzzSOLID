using FizzBuzzSOLID;
using FizzBuzzSOLID.Service;
using FizzBuzzSOLID.Service.Interfaces;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Fizz Buzz SOLID");
Console.WriteLine("----------------------");

var services = new ServiceCollection().AddSingleton<IFizzBuzzService>(new FizzBuzzService());

using (var serviceProvider = services.BuildServiceProvider())
{
    var fizzBuzzService = serviceProvider.GetService<IFizzBuzzService>();
    FizzBuzzFunctions.Output(fizzBuzzService);
}
