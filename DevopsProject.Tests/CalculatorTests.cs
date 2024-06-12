namespace DevopsProject.Tests;

public class CalculatorTests
{
    private readonly IMiniCalculator _sut = new MiniCalculator();
    
    [Fact]
    public void Should_ReturnFive_WhenTwoPlusThree()
    {
        Assert.Equal(5, _sut.Summarize(2 , 3));
    }
    
    [Fact]
    public void Should_ReturnThree_WhenTOnePlusTwo()
    {
        Assert.Equal(-3, _sut.Summarize(-1 , -2));
    }
    
    [Fact]
    public void Should_ReturnTen_WhenTFivePlusFive()
    {
        Assert.Equal(10, _sut.Summarize(5 , 5));
    }
    
    [Fact]
    public void Should_ReturnZero_WhenMinusOnePlusOne()
    {
        Assert.Equal(0, _sut.Summarize(-1 , 1));
    }
    
    [Fact]
    public void Should_ReturnOneHundred_WhenFiftyPlusFifty()
    {
        Assert.Equal(100, _sut.Summarize(50 , 50));
    }
}