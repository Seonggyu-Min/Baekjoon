using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] prices) {
        // Monotonic Stack 문제 같음
        // N <= 100,000 이므로 O(N) 고려

        // 뒤에서 부터 순회
        // 비교하고 있는 i보다 stack에 큰 것이 있으면 Pop

        // 다만 가격이 언제 떨어지는지도 확인해야되므로 튜플로 배열 인덱스, 가격 기록
        var stack = new Stack<(int index, int price)>();
        var result = new int[prices.Length];

        for (int i = prices.Length - 1; i >= 0; i--)
        {
            // 현재 가격보다 크거나 같은 가격이 있는지 확인
            while (stack.TryPeek(out var t) && prices[i] <= t.price)
            {
                stack.Pop();
            }

            // Peek 해서 나온 것이 현재 i보다 작은 것이 보장됨
            if (stack.TryPeek(out var p))
            {
                result[i] = p.index - i;
            }
            else
            {
                result[i] = (prices.Length - 1) - i;
            }

            stack.Push((i, prices[i]));
        }

        return result;
    }
}