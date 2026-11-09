using CICDDemoProject;

namespace CICDDemo.Tests;

public class UnitTest1
{
    [Fact]
    public void Add_TwoNumbers_ReturnsCorrectSum()
    {
        // Arrange
        int a = 5;
        int b = 3;

        // Act
        int result = Calculator.Add(a, b);

        // Assert
        Assert.Equal(8, result);
    }
}
