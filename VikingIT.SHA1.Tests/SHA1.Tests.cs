using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VikingIT.Extensions.Tests
{
  [TestClass]
  public class ExtensionTests
  {
    [TestMethod]
    public void GetSHA1StringTest()
    {
      var checksum = "82CBA02E2C7DFBC7D46DDAD65995B1DF7EB45C34";
      var value = "Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.";

      Assert.IsTrue(value.GetSHA1() == checksum);

      value = "Far far away";
      Assert.IsFalse(value.GetSHA1() == checksum);
    }

    [TestMethod]
    public void GetSHA1ObjectTest()
    {
      var checksum = "F6116F7E8E526415581F26F23A65C4AF7DA0F0B8";
      var value = new TestObject()
      {
        Level = 1,
        Name = "TestObject",
        NestedObject = new NestedObject()
        {
          Level = 2,
          Name = "NestedObject",
        }
      };

      Assert.IsTrue(value.GetSHA1() == checksum);

      value.Level = 0;
      value.NestedObject.Level = 1;

      Assert.IsFalse(value.GetSHA1() == checksum);
    }
  }

  public class TestObject
  {
    public int Level { get; set; }
    public string Name { get; set; }
    public NestedObject NestedObject { get; set; }
  }

  public class NestedObject
  {
    public int Level { get; set; }
    public string Name { get; set; }
  }
}