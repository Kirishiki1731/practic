using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
    public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
    {
        T? previous = default(T);
        List<T> result = new List<T>();

        foreach (T item in iterable)
        {
            if (!EqualityComparer<T>.Default.Equals(item, previous))
            {
                result.Add(item);
                previous = item;
            }
        }

        return result;
    }
}