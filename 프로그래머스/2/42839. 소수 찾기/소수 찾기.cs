using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string numbers) {
        // 1 <= numbers.Length <= 7

        // n = 7
        // nP1 + nP2 + ... nP7 = 7 + 42 + 210 + 840 + 2520 + 5040 + 5040
        // = 13,699
        // 완전탐색 가능

        var set = new HashSet<int>();
        var visited = new bool[numbers.Length];

        // 1. 만들 수 있는 수 조합
        DFS(0);

        int count = 0;
        // 2. 소수 판별
        foreach (var item in set)
        {
            if (IsPrime(item))
            {
                count++;
            }
        }

        return count;


        void DFS(int value)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (visited[i])
                {
                    continue;
                }

                visited[i] = true;

                int nextValue = value * 10 + (numbers[i] - '0');
                set.Add(nextValue);

                DFS(nextValue);

                visited[i] = false;
            }
        }

        bool IsPrime(int value)
        {
            if (value < 2)
            {
                return false;
            }
            else if (value == 2)
            {
                return true;
            }
            else if (value % 2 == 0)
            {
                return false;
            }

            for (int i = 3; i <= value / i; i++)
            {
                if (value % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}