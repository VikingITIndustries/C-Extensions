using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VikingIT.Extensions.Tests
{
  [TestClass]
  public class ExtensionTests
  {
    [TestMethod]
    public void IsNullTest()
    {
      int? value = null;
      Assert.IsTrue(value.IsNullOrNeg1());

      value = 0;
      Assert.IsFalse(value.IsNullOrNeg1());
    }

    [TestMethod]
    public void IsNullOrNeg1Test()
    {
      int? value = -1;
      Assert.IsTrue(value.IsNullOrNeg1());

      value = null;
      Assert.IsTrue(value.IsNullOrNeg1());

      value = 0;
      Assert.IsFalse(value.IsNullOrNeg1());
    }

    [TestMethod]
    public void IsNullOrZeroTest()
    {
      int? value = -1;
      Assert.IsFalse(value.IsNullOrZero());

      value = null;
      Assert.IsTrue(value.IsNullOrZero());

      value = 0;
      Assert.IsTrue(value.IsNullOrZero());
    }
  }
}