using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] topping) {
        int answer = 0;
        
        var left = new Dictionary<int/*topping*/, int/*quantity*/>();
        var right = new Dictionary<int/*topping*/, int/*quantity*/>();

        // 오른쪽 전체 초기화
        for (int i = 0; i < topping.Length; i++)
        {
            var key = topping[i];

            if (right.TryGetValue(key, out var count))
            {
                right[key] = count + 1;
            }
            else
            {
                right[key] = 1;
            }
        }

        for (int i = 0; i < topping.Length; i++)
        {
            var key = topping[i];

            if (left.TryGetValue(topping[i], out var leftCount))
            {
                left[key] = leftCount + 1;
            }
            else
            {
                left[key] = 1;
            }

            if (right.TryGetValue(topping[i], out var rightCount))
            {
                if (1 < rightCount)
                {
                    right[key] = rightCount - 1;
                }
                else
                {
                    right.Remove(key);
                }
            }

            if (left.Count == right.Count)
            {
                answer++;
            }
        }

        return answer;
    }
}