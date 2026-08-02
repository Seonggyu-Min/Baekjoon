using System;

public class Solution {
    public int solution(int[] numbers, int target) {
        // N <= 20
        // 트리구조로 뻗어나가면서 탐색
        // 재귀 방식으로 트리 구현해도 최대 깊이 20이라서 StackOverflow 발생하지 않을 듯

        int answer = 0;

        DFS(true, 0, 0);
        DFS(false, 0, 0);
        
        return answer;

        void DFS(bool isPositive, int depth, int sum)
        {
            if (isPositive)
            {
                sum += numbers[depth];
            }
            else
            {
                sum -= numbers[depth];
            }

            if (depth == numbers.Length - 1)
            {
                if (sum == target)
                {
                    answer++;
                }
                return;
            }

            DFS(true, depth + 1, sum);
            DFS(false, depth + 1, sum);
        }
    }
}