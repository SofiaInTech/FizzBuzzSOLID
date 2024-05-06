using FizzBuzzSOLID.Service.Interfaces;

namespace FizzBuzzSOLID.Service;

public class FizzBuzzService : IFizzBuzzService
{
    public string CalculateFizzBuzzResult(int number)
    {
        if (number % 15 == 0)
        {
            return "Fizzbuzz";
        }

        if (number % 3 == 0)
        {
            return "Fizz";
        }

        if (number % 5 == 0)
        {
            return "Buzz";
        }

        return number.ToString();
    }
}

