using System;
using FizzBuzzSOLID.Service.Interfaces;

namespace FizzBuzzSOLID
{
	public static class FizzBuzzFunctions
	{
		public static void Output(IFizzBuzzService? fizzBuzzService)
		{
            var range = Enumerable.Range(1, 100);

            foreach (int number in range)
            {
                Console.WriteLine(fizzBuzzService?.CalculateFizzBuzzResult(number));
            }
        }
	}
}

