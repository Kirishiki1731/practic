using System;
using System.Text;

public class Kata
{
    public static string BreakCamelCase(string str)
    {
        StringBuilder sb = new StringBuilder();

        foreach (char c in str)
        {
            if (char.IsUpper(c))
            {
                sb.Append(" ");
            }
            sb.Append(c);
        }

        return sb.ToString();
    }
}