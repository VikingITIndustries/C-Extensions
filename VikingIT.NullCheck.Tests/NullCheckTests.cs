using Xunit;

namespace VikingIT.Extensions.Tests
{
  public class ExtensionTests
  {
    [Theory]
    [InlineData(null, true)]
    [InlineData(-1, false)]
    [InlineData(0, false)]
    [InlineData(1, false)]
    public void IsNull(int? value, bool expectedValue)
    {
      Assert.True(value.IsNull() == expectedValue);
    }

    [Theory]
    [InlineData(null, true)]
    [InlineData(-1, true)]
    [InlineData(0, false)]
    [InlineData(1, false)]
    public void IsNullOrNeg1(int? value, bool expectedValue)
    {
      Assert.True(value.IsNullOrNeg1() == expectedValue);
    }

    [Theory]
    [InlineData(null, true)]
    [InlineData(-1, false)]
    [InlineData(0, true)]
    [InlineData(1, false)]
    public void IsNullOrZero(int? value, bool expectedValue)
    {
      Assert.True(value.IsNullOrZero() == expectedValue);
    }
  }
}