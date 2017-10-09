namespace VikingIT.Extensions
{
  public static class Extension
  {
    public static bool IsNull(this int? value) => value == null;

    public static bool IsNullOrNeg1(this int? value) => value.IsNull() || value == -1;

    public static bool IsNullOrZero(this int? value) => value.IsNull() || value == 0;
  }
}