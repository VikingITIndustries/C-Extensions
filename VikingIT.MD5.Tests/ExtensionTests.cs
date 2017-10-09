using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VikingIT.Extensions.Tests
{
  [TestClass]
  public class ExtensionTests
  {
    [TestMethod]
    public void GetMD5StringTest()
    {
      var checksum = "8E3B1FA76A71830A0E2A2D988EC54D20";
      var value = "Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.";
      Assert.IsTrue(value.GetMD5() == checksum);

      value = "Far far away";
      Assert.IsFalse(value.GetMD5() == checksum);
    }

    [TestMethod]
    public void GetMD5ObjectTest()
    {
      var checksum = "61274DBD490CB8A65053BE7B12BCD18F";
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

      Assert.IsTrue(value.GetMD5() == checksum);

      value.Level = 0;
      value.NestedObject.Level = 1;

      Assert.IsFalse(value.GetMD5() == checksum);
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