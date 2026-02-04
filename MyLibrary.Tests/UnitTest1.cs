namespace MyLibrary.Tests;

public class UnitTest1
{
    [Fact]
    public void Add_ReturnsCorrectSum()
    {
        // Arrange
        var calculator = new Calculator();
        
        // Act
        var result = calculator.Add(2, 2);
        
        // Assert
        Assert.Equal(4, result);
    }
}
