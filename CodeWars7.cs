using System;
using System.Linq;

public static class Kata
{
    public static string Order(string words)
    {
        if (string.IsNullOrEmpty(words))
        {
            return "";
        }

        string[] wordArray = words.Split(' ');
        string[] orderedArray = new string[wordArray.Length];

        foreach (string word in wordArray)
        {
            int position = word.FirstOrDefault(char.IsDigit) - '0' - 1;

            orderedArray[position] = word;
        }

        return string.Join(" ", orderedArray);
    }
}