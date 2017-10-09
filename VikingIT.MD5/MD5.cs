using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;

namespace VikingIT.Extensions
{
  public static class Extension
  {
    public static string GetMD5<T>(this T value)
    {
      var xml = new XmlSerializer(value.GetType());
      using (var writer = new StringWriter())
      {
        xml.Serialize(writer, value);
        return GetMD5(writer.ToString());
      }
    }

    public static string GetMD5(this string value)
    {
      using (var md5 = MD5.Create())
      {
        return BitConverter.ToString(
          md5.ComputeHash(Encoding.UTF8.GetBytes(value))
        ).Replace("-", String.Empty);
      }
    }
  }
}