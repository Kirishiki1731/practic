using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static string SpinWords(string sentence)
    {
        if (string.IsNullOrEmpty(sentence))
        {
            return "";
        }

        string[] words = sentence.Split(' ');
        List<string> spunWords = new List<string>();

        foreach (string word in words)
        {
            if (word.Length >= 5)
            {
                char[] charArray = word.ToCharArray();
                Array.Reverse(charArray);
                spunWords.Add(new string(charArray));
            }
            else
            {
                spunWords.Add(word);
            }
        }

        return string.Join(" ", spunWords);
    }
}