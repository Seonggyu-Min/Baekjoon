using System;
using System.Text;

public class Solution {
    public string solution(string[] arr) {
        var sb = new StringBuilder(arr.Length);

        foreach (var c in arr)
        {
            sb.Append(c);
        }

        return sb.ToString();
    }
}