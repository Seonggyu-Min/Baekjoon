using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] order) {
        // n <= 1,000,000
        // O(n)까지 고려

        int main = 1;
        int orderIdx = 0;
        int result = 0;

        var stack = new Stack<int>();

        while (orderIdx < order.Length)
        {
            int target = order[orderIdx];

            // 보조 벨트 -> 트럭
            if (stack.TryPeek(out var top) && top == target)
            {
                stack.Pop();
                orderIdx++;
                result++;
            }
            // 메인 벨트 -> 트럭
            else if (main == target)
            {
                main++;
                orderIdx++;
                result++;
            }
            // 메인 벨트 -> 보조 벨트
            else if (main < target)
            {
                stack.Push(main);
                main++;
            }
            // 둘 다 target을 꺼낼 수 없음
            else
            {
                break;
            }
        }

        return result;
    }
}