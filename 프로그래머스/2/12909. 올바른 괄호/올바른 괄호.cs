using System;
using System.Collections.Generic;

public class Solution {
    public bool solution(string s) {
        var stack = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                stack.Push(s[i]);
            }
            else
            {
                if (stack.Count == 0) return false;

                stack.Pop();
            }
        }

        return stack.Count == 0 ? true : false;
    }
}