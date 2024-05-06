namespace FizzBuzzSOLID.Service.Interfaces
{
    public interface IFizzBuzzService
    {
        /// <summary>
        /// Takes an integer and returns its Fizzbuzz result as a string.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>'Fizz' for numbers divisible by 3,
        /// 'Buzz' for numbers divisible by 5, and 'Fizzbuzz' for numbers divisible by both.
        /// If none are true returns just the number.</returns>
        public string CalculateFizzBuzzResult(int number);
	}
}
