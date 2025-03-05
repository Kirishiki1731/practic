using System;
using System.Linq;

public class Kata
{
    public static int[] SortArray(int[] array)
    {
        int[] oddNumbers = array.Where(n => n % 2 != 0).OrderBy(n => n).ToArray();

        int[] result = new int[array.Length];

        int oddIndex = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                result[i] = array[i];
            }
            else
            {
                result[i] = oddNumbers[oddIndex];
                oddIndex++;
            }
        }

        return result;
    }
}