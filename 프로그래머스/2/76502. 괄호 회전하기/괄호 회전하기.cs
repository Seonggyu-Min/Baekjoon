using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string s) {
        // 반복문을 돌면서 현재 괄호가 올바른지 검사
        var stack = new Stack<char>();
        int vaildCount = 0;

        // stack 포인터 밀기용 순회
        for (int i = 0; i < s.Length; i++)
        {
            // 0 ~ i / 1 ~ i ~ i + 1 / 2 ~ i ~ i + 1 ~ i + 2 ...
            stack.Clear();

            bool isValid = true;
            // 괄호 유효한지 검사
            for (int j = i; j < i + s.Length; j++)
            {
                int temp = j % s.Length;

                if (stack.TryPeek(out var peek))
                {
                    if (s[temp] == ')')
                    {
                        if (peek != '(')
                        {
                            isValid = false;
                            break;
                        }
                        else
                        {
                            stack.Pop();
                            continue;
                        }
                    }
                    else if (s[temp] == '}')
                    {
                        if (peek != '{')
                        {
                            isValid = false;
                            break;
                        }
                        else
                        {
                            stack.Pop();
                            continue;
                        }
                    }
                    else if (s[temp] == ']')
                    {
                        if (peek != '[')
                        {
                            isValid = false;
                            break;
                        }
                        else
                        {
                            stack.Pop();
                            continue;
                        }
                    }
                }

                stack.Push(s[temp]);
            }

            if (isValid && stack.Count == 0)
            {
                vaildCount++;
            }
        }

        return vaildCount;
    }
}