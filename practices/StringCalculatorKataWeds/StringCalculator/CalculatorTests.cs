

namespace StringCalculator;
public class CalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new Calculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }
    [Theory]
    [InlineData("2", 2)]
    [InlineData("-3", -3)]
    [InlineData("0", 0)]
    public void ConvertOneInt(string numbers, int value)
    {
        var calculator = new Calculator();
        var result = calculator.Add(numbers);

        Assert.Equal(value, result);
    }

    [Theory]
    [InlineData("2,3", 5)]
    [InlineData("-3,-2", -5)]
    [InlineData("-3,2", -1)]
    [InlineData("7,0", 7)]
    public void ConvertTwoInts(string numbers, int value)
    {
        var calculator = new Calculator();
        var result = calculator.Add(numbers);

        Assert.Equal(value, result);
    }

    [Theory]
    [InlineData("2,3,7,19", 31)]
    [InlineData("2,3,7,9", 21)]
    [InlineData("-3,-2,-4", -9)]
    [InlineData("-3,2,-7,-5,7", -6)]
    [InlineData("-10, -12,-34545", -34567)]
    public void ConvertManyInts(string numbers, int value)
    {
        var calculator = new Calculator();
        var result = calculator.Add(numbers);

        Assert.Equal(value, result);
    }

}
