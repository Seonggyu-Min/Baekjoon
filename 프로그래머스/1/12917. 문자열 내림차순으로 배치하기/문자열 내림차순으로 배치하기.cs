using System;
using System.Text;

public class Solution {
    public string solution(string s) {
        char[] arr = s.ToCharArray();
        Array.Sort(arr);
        Array.Reverse(arr);

        var sb = new StringBuilder();
        foreach (var c in arr)
        {
            sb.Append(c);
        }

        return sb.ToString();
    }
}