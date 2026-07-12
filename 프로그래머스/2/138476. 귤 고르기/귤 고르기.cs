using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int k, int[] tangerine) {
        // 1. 크기별로 분류
        var dict = new Dictionary<int/*scale*/, int/*count*/>();

        for (int i = 0; i < tangerine.Length; i++)
        {
            if (dict.ContainsKey(tangerine[i]))
            {
                dict[tangerine[i]]++;
            }
            else
            {
                dict[tangerine[i]] = 1;
            }
        }

        var list = dict.OrderByDescending(x => x.Value).ToList();

        // 2. k개의 박스에 많은 순서부터 넣어보기
        int count = 0;
        int repeat = 0;
        while (count < k)
        {
            count += list[repeat].Value;
            repeat++;
        }

        // 3. 넣은 종류 반환
        return repeat;
    }
}