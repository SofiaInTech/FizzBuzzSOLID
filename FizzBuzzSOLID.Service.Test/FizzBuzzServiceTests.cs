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
    [TestCase(2, "2")]
    [TestCase(20, "Buzz")]
    [TestCase(32, "32")]
    [TestCase(60, "Fizzbuzz")]
    [TestCase(-18, "Fizz")]
    [TestCase(0, "Fizzbuzz")]
    [TestCase(333, "Fizz")]
    public void CalculateFizzBuzzResult(int number, string expectedResult)
    {
        var actualResult = _fizzBuzzService.CalculateFizzBuzzResult(number);
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}
