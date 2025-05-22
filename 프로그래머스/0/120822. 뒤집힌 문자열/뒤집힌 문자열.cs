using System;

public class Solution {
    public string solution(string my_string) {
        int k = 0;
        char[] c = new char[my_string.Length];

        for (int i = my_string.Length - 1; i >= 0; i--)
        {
            c[k] = my_string[i];
            k++;
        }

        return new string(c);
    }
}