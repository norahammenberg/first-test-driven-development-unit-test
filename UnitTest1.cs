using Xunit;

namespace triangle;

public class UnitTest1
{
    Triangle triangle = new Triangle();
    [Fact]
    public void Test1()
    {

        Assert.Equal("Equilateral", triangle.getType(1, 1, 1));
    }

    [Fact]
    public void Test2()
    {
        Assert.Equal("Isosceles", triangle.getType(1, 1, 2));
    }

    [Fact]
    public void Test3()
    {
        Assert.Equal("Scalene", triangle.getType(1, 3, 2));
    }
}