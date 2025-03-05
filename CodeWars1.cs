using System;
using System.Collections;
using System.Collections.Generic;

public class ListFilterer
{
    public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
    {
        List<int> result = new List<int>();

        foreach (object item in listOfItems)
        {
            if (item is int)
            {
                int intValue = (int)item;
                if (intValue >= 0) 
                {
                    result.Add(intValue);
                }
            }
        }

        return result;
    }

    public static void Main(string[] args)
    {
        List<object> mixedList = new List<object>() { 1, 2, "a", "b", 0, -5 };
        IEnumerable<int> integerList = GetIntegersFromList(mixedList);
    }
}