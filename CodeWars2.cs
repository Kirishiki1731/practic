using System;
using System.Linq;

public static class Kata
{
  public static string HighAndLow(string numbers)
  {
    string[] numberStrings = numbers.Split(' ');
    int[] nums = numberStrings.Select(int.Parse).ToArray();

    int max = nums.Max();
    int min = nums.Min();

    return $"{max} {min}";
  }
}