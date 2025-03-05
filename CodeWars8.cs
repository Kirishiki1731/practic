using System;
using System.Text;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Kata
{
    public static class Problem
    {
        public static string CamelCase(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return string.Empty;
            }

            string[] words = str.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder sb = new StringBuilder();

            foreach (string word in words)
            {
                if (word.Length > 0)
                {
                    sb.Append(char.ToUpper(word[0]));
                    sb.Append(word.Substring(1).ToLower());
                }
            }

            return sb.ToString();
        }
    }
}