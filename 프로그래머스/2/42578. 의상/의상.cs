using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[,] clothes) {
        var dict = new Dictionary<string/*category*/, int/*count*/>();

        for (int i = 0; i < clothes.GetLength(0); i++)
        {
            if (dict.TryGetValue(clothes[i, 1], out var value))
            {
                dict[clothes[i, 1]] = value + 1;
            }
            else
            {
                dict[clothes[i, 1]] = 1;
            }
        }

        // 각 카테고리별 경우의 수
        // 의상 + 1개의 경우 (안입는 경우)
        // 조합이니까 곱함
        // 그리고 모든 것을 안입는 경우 1개를 빼기
        int sum = 1;
        foreach (var count in dict.Values)
        {
            sum *= count + 1;
        }

        return sum - 1;
    }
}