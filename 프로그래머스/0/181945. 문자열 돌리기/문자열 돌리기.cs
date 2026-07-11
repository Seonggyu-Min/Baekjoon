using System;
using System.Text;

public class Example
{
    public static void Main()
    {
        string s = Console.ReadLine();

        var sb = new StringBuilder();
        foreach (var c in s)
        {
            sb.Append(c).AppendLine();
        }

        Console.WriteLine(sb.ToString());
    }
}