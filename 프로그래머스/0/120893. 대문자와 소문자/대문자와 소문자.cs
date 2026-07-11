using System;
using System.Text;

public class Solution {
    public string solution(string my_string) {
            var sb = new StringBuilder();

            foreach (var c in my_string)
            {
                if (c <= 'Z')
                {
                    sb.Append((char)(c + 32));
                }
                else
                {
                    sb.Append((char)(c - 32));
                }
            }

            return sb.ToString();
    }
}