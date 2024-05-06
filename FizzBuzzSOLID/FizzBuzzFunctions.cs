using FizzBuzzSOLID.Service.Interfaces;

namespace FizzBuzzSOLID
{
    public static class FizzBuzzFunctions
	{
        /// <summary>
        /// Iterates over numbers 1 to 100 outputting their Fizzbuzz result.
        /// </summary>
        /// <param name="fizzBuzzService"></param>
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

