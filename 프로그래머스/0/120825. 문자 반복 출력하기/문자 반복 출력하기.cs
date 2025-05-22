using System;

public class Solution {
    public string solution(string my_string, int n) {
        char[] c = new char[my_string.Length * n];

        for (int i = 0; i < my_string.Length; i++)
            for (int k = 1; k <= n; k++)
                c[i * n + k - 1] = my_string[i];

        return new string(c);
    }
}