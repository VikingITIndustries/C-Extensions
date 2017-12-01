using System;
using System.Linq;

namespace VikingIT.Extensions
{
  public static class Extension
  {
    private static readonly string[] trueValues = { "t", "true", "y", "yes", "1" };
    private static readonly string[] falseValues = { "f", "false", "n", "no", "0" };

    public static bool ToBoolean(this string value)
    {
      value = value?.Trim().ToLower();

      if (!trueValues.Union(falseValues).Contains(value))
      {
        throw new ArgumentException($"{value} cannot be converted to Boolean");
      }

      return trueValues.Contains(value);
    }
  }
}