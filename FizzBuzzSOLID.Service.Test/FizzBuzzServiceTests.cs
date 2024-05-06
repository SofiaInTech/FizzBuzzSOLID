using FizzBuzzSOLID.Service.Interfaces;

namespace FizzBuzzSOLID.Service.Test;

public class FizzBuzzServiceTests
{
    private IFizzBuzzService _fizzBuzzService;

    [SetUp]
    public void Setup()
    {
        _fizzBuzzService = new FizzBuzzService();
    }

    [TestCase(15, "Fizzbuzz")]
    [TestCase(3, "Fizz")]
    public void CalculateFizzBuzzResult(int number, string expectedResult)
    {
        var actualResult = _fizzBuzzService.CalculateFizzBuzzResult(number);
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}
