using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] topping) {
        int answer = 0;

        var left = new Dictionary<int, int>();
        var right = new Dictionary<int, int>();

        for (int i = 0; i < topping.Length; i++)
        {
            int key = topping[i];

            if (right.TryGetValue(key, out int count))
            {
                right[key] = count + 1;
            }
            else
            {
                right[key] = 1;
            }
        }

        for (int i = 0; i < topping.Length - 1; i++)
        {
            int key = topping[i];

            if (left.TryGetValue(key, out int leftCount))
            {
                left[key] = leftCount + 1;
            }
            else
            {
                left[key] = 1;
            }

            int rightCount = right[key];

            if (rightCount == 1)
            {
                right.Remove(key);
            }
            else
            {
                right[key] = rightCount - 1;
            }

            if (left.Count == right.Count)
            {
                answer++;
            }
        }

        return answer;
    }
}