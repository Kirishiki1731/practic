using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int GetUnique(IEnumerable<int> numbers)
    {
        var groupedNumbers = numbers.GroupBy(x => x);

        foreach (var group in groupedNumbers)
        {
            if (group.Count() == 1)
            {
                return group.Key;
            }
        }

        return 0;
    }
}