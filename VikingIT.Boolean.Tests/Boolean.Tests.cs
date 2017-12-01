using System;
using Xunit;

namespace VikingIT.Extensions.Tests
{
  public class ExtensionTests
  {
    [Theory]
    [InlineData("t")]
    [InlineData("y")]
    [InlineData("1")]
    [InlineData("yes")]
    [InlineData("true")]
    [InlineData("TRUE")]
    [InlineData("    TRUE    ")]
    public void ToBooleanTrue(string value)
    {
      Assert.True(value.ToBoolean());
    }

    [Theory]
    [InlineData("f")]
    [InlineData("n")]
    [InlineData("0")]
    [InlineData("no")]
    [InlineData("false")]
    [InlineData("FALSE")]
    [InlineData("    FALSE    ")]
    public void ToBooleanFalse(string value)
    {
      Assert.False(value.ToBoolean());
    }

    [Theory]
    [InlineData(null)]
    [InlineData("tr")]
    [InlineData("ue")]
    [InlineData("help")]
    public void ToBooleanArgEx(string value)
    {
      Assert.Throws<ArgumentException>(() => value.ToBoolean());
    }
  }
}