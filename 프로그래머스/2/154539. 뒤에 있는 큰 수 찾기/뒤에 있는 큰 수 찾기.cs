using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers) {
        // n <= 1,000,000
        // O(n)급 필요

        var stack = new Stack<int>();
        var result = new int[numbers.Length];

        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            // 스택이 비어있으면 - 1
            if (stack.Count == 0)
            {
                result[i] = -1;
                stack.Push(numbers[i]);
                continue;
            }
            // 스택이 비어있지 않으면
            else
            {
                // 꺼내보면서 현재 값보다 크지 않은 수 제거
                while (0 < stack.Count && stack.Peek() <= numbers[i])
                {
                    stack.Pop();
                }

                // 이후에도 스택이 남아있으면 Peek 대입, 없으면 -1
                if (0 < stack.Count)
                {
                    result[i] = stack.Peek();
                }
                else
                {
                    result[i] = -1;
                }

                stack.Push(numbers[i]);
            }
        }

        return result;
    }
}