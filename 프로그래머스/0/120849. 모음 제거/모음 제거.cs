using System;
using System.Text;

public class Solution {
    public string solution(string my_string) {
            var sb = new StringBuilder(my_string.Length);

            foreach (var c in my_string)
            {
                if (c is 'a' or 'e' or 'i' or 'o' or 'u') continue;

                sb.Append(c);
            }

            return sb.ToString();
    }
}