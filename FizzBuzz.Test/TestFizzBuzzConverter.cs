using FluentAssertions;

namespace FizzBuzz.Test;

public class TestFizzBuzzConverter
{
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(8)]
    [InlineData(16)]
    [InlineData(32)]
    public void Convert_CalledWithNonMultiple_ShouldReturnGivenNumberAsString(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be(number.ToString());
    }

    [Theory]
    [InlineData(3 * 1)]
    [InlineData(3 * 2)]
    [InlineData(3 * 3)]
    [InlineData(3 * 4)]
    public void Convert_CalledWithMultipleOf3_ShouldReturnFizz(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("Fizz");
    }

    [Theory]
    [InlineData(5 * 1)]
    [InlineData(5 * 2)]
    [InlineData(5 * 4)]
    [InlineData(5 * 5)]
    public void Convert_CalledWithMultipleOf5_ShouldReturnBuzz(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("Buzz");
    }

    [Theory]
    [InlineData(3 * 5)]
    [InlineData(3 * 5 * 2)]
    public void Convert_CalledWithMultipleOf3And5_ShouldReturnFizzBuzz(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("FizzBuzz");
    }

    [Theory]
    [InlineData(7 * 1)]
    [InlineData(7 * 2)]
    [InlineData(7 * 4)]
    [InlineData(7 * 7)]
    public void Convert_CalledWithMultipleOf7_ShouldReturnBang(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("Bang");
    }

    [Theory]
    [InlineData(3 * 7)]
    [InlineData(3 * 7 * 2)]
    public void Convert_CalledWithMultipleOf3And7_ShouldReturnFizzBang(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("FizzBang");
    }

    [Theory]
    [InlineData(5 * 7)]
    [InlineData(5 * 7 * 2)]
    public void Convert_CalledWithMultipleOf5And7_ShouldReturnBuzzBang(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("BuzzBang");
    }

    [Theory]
    [InlineData(3 * 5 * 7)]
    public void Convert_CalledWithMultipleOf3And5And7_ShouldReturnFizzBuzzBang(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("FizzBuzzBang");
    }

    [Theory]
    [InlineData(11 * 1)]
    [InlineData(11 * 2)]
    [InlineData(11 * 4)]
    [InlineData(11 * 11)]
    public void Convert_CalledWithMultipleOf11_ShouldReturnBong(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("Bong");
    }

    [Theory]
    [InlineData(3 * 11)]
    [InlineData(3 * 11 * 2)]
    public void Convert_CalledWithMultipleOf3And11_ShouldReturnBong(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("Bong");
    }

    [Theory]
    [InlineData(5 * 11)]
    [InlineData(5 * 11 * 2)]
    public void Convert_CalledWithMultipleOf5And11_ShouldReturnBong(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("Bong");
    }

    [Theory]
    [InlineData(7 * 11)]
    [InlineData(7 * 11 * 2)]
    public void Convert_CalledWithMultipleOf7And11_ShouldReturnBong(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("Bong");
    }

    [Theory]
    [InlineData(3 * 5 * 11)]
    public void Convert_CalledWithMultipleOf3And5And11_ShouldReturnBong(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("Bong");
    }

    [Theory]
    [InlineData(3 * 7 * 11)]
    public void Convert_CalledWithMultipleOf3And7And11_ShouldReturnBong(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("Bong");
    }

    [Theory]
    [InlineData(5 * 7 * 11)]
    public void Convert_CalledWithMultipleOf5And7And11_ShouldReturnBong(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("Bong");
    }

    [Theory]
    [InlineData(3 * 5 * 7 * 11)]
    public void Convert_CalledWithMultipleOf3And5And7And11_ShouldReturnBong(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("Bong");
    }

    [Theory]
    [InlineData(13 * 1)]
    [InlineData(13 * 2)]
    [InlineData(13 * 4)]
    [InlineData(13 * 13)]
    public void Convert_CalledWithMultipleOf13_ShouldReturnFezz(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("Fezz");
    }

    [Theory]
    [InlineData(3 * 13)]
    [InlineData(3 * 13 * 2)]
    public void Convert_CalledWithMultipleOf3And13_ShouldReturnFizzFezz(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("FizzFezz");
    }

    [Theory]
    [InlineData(5 * 13)]
    [InlineData(5 * 13 * 2)]
    public void Convert_CalledWithMultipleOf5And13_ShouldReturnFezzBuzz(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("FezzBuzz");
    }

    [Theory]
    [InlineData(7 * 13)]
    [InlineData(7 * 13 * 2)]
    public void Convert_CalledWithMultipleOf7And13_ShouldReturnFezzBang(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("FezzBang");
    }

    [Theory]
    [InlineData(11 * 13)]
    [InlineData(11 * 13 * 2)]
    public void Convert_CalledWithMultipleOf11And13_ShouldReturnFezzBong(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("FezzBong");
    }

    [Theory]
    [InlineData(3 * 5 * 13)]
    public void Convert_CalledWithMultipleOf3And5And13_ShouldReturnFizzFezzBuzz(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("FizzFezzBuzz");
    }

    [Theory]
    [InlineData(3 * 7 * 13)]
    public void Convert_CalledWithMultipleOf3And7And13_ShouldReturnFizzFezzBang(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("FizzFezzBang");
    }

    [Theory]
    [InlineData(3 * 11 * 13)]
    public void Convert_CalledWithMultipleOf3And11And13_ShouldReturnFezzBong(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("FezzBong");
    }

    [Theory]
    [InlineData(5 * 7 * 13)]
    public void Convert_CalledWithMultipleOf5And7And13_ShouldReturnFezzBuzzBang(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("FezzBuzzBang");
    }

    [Theory]
    [InlineData(5 * 11 * 13)]
    public void Convert_CalledWithMultipleOf5And11And13_ShouldReturnFezzBong(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("FezzBong");
    }

    [Theory]
    [InlineData(7 * 11 * 13)]
    public void Convert_CalledWithMultipleOf7And11And13_ShouldReturnFezzBong(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("FezzBong");
    }

    [Theory]
    [InlineData(3 * 5 * 7 * 13)]
    public void Convert_CalledWithMultipleOf3And5And7And13_ShouldReturnFizzFezzBuzzBang(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("FizzFezzBuzzBang");
    }

    [Theory]
    [InlineData(3 * 5 * 11 * 13)]
    public void Convert_CalledWithMultipleOf3And5And11And13_ShouldReturnFezzBong(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("FezzBong");
    }

    [Theory]
    [InlineData(5 * 7 * 11 * 13)]
    public void Convert_CalledWithMultipleOf5And7And11And13_ShouldReturnFezzBong(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("FezzBong");
    }

    [Theory]
    [InlineData(3 * 5 * 7 * 11 * 13)]
    public void Convert_CalledWithMultipleOf3And5And7And11And13_ShouldReturnFezzBong(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("FezzBong");
    }

    [Theory]
    [InlineData(17 * 1)]
    [InlineData(17 * 2)]
    [InlineData(17 * 4)]
    [InlineData(17 * 17)]
    public void Convert_CalledWithMultipleOf17_ShouldReturnGivenNumberAsString(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be(number.ToString());
    }

    [Theory]
    [InlineData(3 * 17)]
    [InlineData(3 * 17 * 2)]
    public void Convert_CalledWithMultipleOf3And17_ShouldReturnFizz(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("Fizz");
    }

    [Theory]
    [InlineData(5 * 17)]
    [InlineData(5 * 17 * 2)]
    public void Convert_CalledWithMultipleOf5And17_ShouldReturnBuzz(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("Buzz");
    }

    [Theory]
    [InlineData(7 * 17)]
    [InlineData(7 * 17 * 2)]
    public void Convert_CalledWithMultipleOf7And17_ShouldReturnBang(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("Bang");
    }

    [Theory]
    [InlineData(11 * 17)]
    [InlineData(11 * 17 * 2)]
    public void Convert_CalledWithMultipleOf11And17_ShouldReturnBong(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("Bong");
    }

    [Theory]
    [InlineData(13 * 17)]
    [InlineData(13 * 17 * 2)]
    public void Convert_CalledWithMultipleOf13And17_ShouldReturnFezz(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("Fezz");
    }

    [Theory]
    [InlineData(3 * 5 * 17)]
    public void Convert_CalledWithMultipleOf3And5And17_ShouldReturnBuzzFizz(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("BuzzFizz");
    }

    [Theory]
    [InlineData(3 * 7 * 17)]
    public void Convert_CalledWithMultipleOf3And7And17_ShouldReturnBangFizz(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("BangFizz");
    }

    [Theory]
    [InlineData(3 * 11 * 17)]
    public void Convert_CalledWithMultipleOf3And11And17_ShouldReturnBong(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("Bong");
    }

    [Theory]
    [InlineData(3 * 13 * 17)]
    public void Convert_CalledWithMultipleOf3And13And17_ShouldReturnFezzFizz(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("FezzFizz");
    }

    [Theory]
    [InlineData(5 * 7 * 17)]
    public void Convert_CalledWithMultipleOf5And7And17_ShouldReturnBangBuzz(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("BangBuzz");
    }

    [Theory]
    [InlineData(5 * 11 * 17)]
    public void Convert_CalledWithMultipleOf5And11And17_ShouldReturnBong(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("Bong");
    }

    [Theory]
    [InlineData(5 * 13 * 17)]
    public void Convert_CalledWithMultipleOf5And13And17_ShouldReturnBuzzFezz(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("BuzzFezz");
    }

    [Theory]
    [InlineData(7 * 11 * 17)]
    public void Convert_CalledWithMultipleOf7And11And17_ShouldReturnBong(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("Bong");
    }

    [Theory]
    [InlineData(7 * 13 * 17)]
    public void Convert_CalledWithMultipleOf7And13And17_ShouldReturnBangFezz(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("BangFezz");
    }

    [Theory]
    [InlineData(11 * 13 * 17)]
    public void Convert_CalledWithMultipleOf11And13And17_ShouldReturnBongFezz(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("BongFezz");
    }

    [Theory]
    [InlineData(3 * 5 * 7 * 17)]
    public void Convert_CalledWithMultipleOf3And5And7And17_ShouldReturnBangBuzzFizz(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("BangBuzzFizz");
    }

    [Theory]
    [InlineData(3 * 5 * 11 * 17)]
    public void Convert_CalledWithMultipleOf3And5And11And17_ShouldReturnBong(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("Bong");
    }

    [Theory]
    [InlineData(3 * 5 * 13 * 17)]
    public void Convert_CalledWithMultipleOf3And5And13And17_ShouldReturnBuzzFezzFizz(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("BuzzFezzFizz");
    }

    [Theory]
    [InlineData(3 * 7 * 11 * 17)]
    public void Convert_CalledWithMultipleOf3And7And11And17_ShouldReturnBong(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("Bong");
    }

    [Theory]
    [InlineData(3 * 7 * 13 * 17)]
    public void Convert_CalledWithMultipleOf3And7And13And17_ShouldReturnBangFezzFizz(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("BangFezzFizz");
    }

    [Theory]
    [InlineData(3 * 11 * 13 * 17)]
    public void Convert_CalledWithMultipleOf3And11And13And17_ShouldReturnBongFezz(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("BongFezz");
    }

    [Theory]
    [InlineData(5 * 7 * 11 * 17)]
    public void Convert_CalledWithMultipleOf5And7And11And17_ShouldReturnBong(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("Bong");
    }

    [Theory]
    [InlineData(5 * 7 * 13 * 17)]
    public void Convert_CalledWithMultipleOf5And7And13And17_ShouldReturnBangBuzzFezz(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("BangBuzzFezz");
    }

    [Theory]
    [InlineData(5 * 11 * 13 * 17)]
    public void Convert_CalledWithMultipleOf5And11And13And17_ShouldReturnBongFezz(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("BongFezz");
    }

    [Theory]
    [InlineData(7 * 11 * 13 * 17)]
    public void Convert_CalledWithMultipleOf7And11And13And17_ShouldReturnBongFezz(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("BongFezz");
    }

    [Theory]
    [InlineData(3 * 5 * 7 * 11 * 17)]
    public void Convert_CalledWithMultipleOf3And5And7And11And17_ShouldReturnBong(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("Bong");
    }

    [Theory]
    [InlineData(3 * 5 * 7 * 13 * 17)]
    public void Convert_CalledWithMultipleOf3And5And7And13And17_ShouldReturnBangBuzzFezzFizz(
        int number
    )
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("BangBuzzFezzFizz");
    }

    [Theory]
    [InlineData(3 * 5 * 11 * 13 * 17)]
    public void Convert_CalledWithMultipleOf3And5And11And13And17_ShouldReturnBongFezz(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("BongFezz");
    }

    [Theory]
    [InlineData(5 * 7 * 11 * 13 * 17)]
    public void Convert_CalledWithMultipleOf5And7And11And13And17_ShouldReturnBongFezz(int number)
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("BongFezz");
    }

    [Theory]
    [InlineData(3 * 5 * 7 * 11 * 13 * 17)]
    public void Convert_CalledWithMultipleOf3And5And7And11And13And17_ShouldReturnBongFezz(
        int number
    )
    {
        var conversionResult = FizzBuzzConverter.Convert(number);
        conversionResult.Should().Be("BongFezz");
    }
}
