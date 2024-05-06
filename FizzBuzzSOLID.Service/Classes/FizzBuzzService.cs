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

        return number.ToString();
    }
}

