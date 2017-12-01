using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;

namespace VikingIT.Extensions
{
  public static class Extension
  {
    public static string GetSHA1<T>(this T value)
    {
      var xml = new XmlSerializer(value.GetType());
      using (var writer = new StringWriter())
      {
        xml.Serialize(writer, value);
        return GetSHA1(writer.ToString());
      }
    }

    public static string GetSHA1(this string value)
    {
      using (var sha1 = SHA1.Create())
      {
        return BitConverter.ToString(
          sha1.ComputeHash(Encoding.UTF8.GetBytes(value))
        ).Replace("-", String.Empty);
      }
    }
  }
}