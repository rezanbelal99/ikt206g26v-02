using Xunit;                 // xUnit namespace
using MyLibrary;             // Your library namespace

namespace MyLibrary.Tests;

public class CalculatorTests // xUnit does NOT use [TestClass]
{
    [Fact]                   // xUnit uses [Fact], NOT [TestMethod]
    public void Add_ReturnsCorrectSum()
    {
        // Arrange
        var calculator = new Calculator();
        
        // Act
        var result = calculator.Add(2, 2);
        
        // Assert
        Assert.Equal(4, result); // xUnit uses Assert.Equal
    }
}
