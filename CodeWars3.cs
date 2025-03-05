using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int Solution(int value)
    {
        if (value < 0)
        {
            return 0;
        }

        List<int> multiples = new List<int>();

        for (int i = 1; i < value; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                multiples.Add(i);
            }
        }

        return multiples.Sum();
    }
}