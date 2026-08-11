using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int x, int y, int n) {
        // 1 <= x <= y <= 1,000,000
        // 1 <= n < y

        // BFS

        // 이미 도달한 경우 바로 반환
        if (x == y)
        {
            return 0;
        }

        // Queue에 필요한 것: 현재 수, 몇 번 계산을 수행했는지
        var queue = new Queue<(int curNum, int count)>();
        // 이미 계산 처리한 것에 대한 중복 방지
        var visited = new bool[y + 1];

        queue.Enqueue((x, 0));
        visited[x] = true;

        int result = -1;

        // n이 1인 최악의 경우 O(y)
        while (0 < queue.Count)
        {
            var (curNum, count) = queue.Dequeue();
            count++;

            var mul2 = curNum * 2;
            var mul3 = curNum * 3;
            var addN = curNum + n;

            // 각 연산 후 목표에 도달했는지 확인
            if (mul2 == y || mul3 == y || addN == y)
            {
                result = count;
                break;
            }

            // 아직 목표에 도달하지 않았다면 계산식 넣기
            if (mul2 < y && !visited[mul2])
            {
                visited[mul2] = true;
                queue.Enqueue((mul2, count));
            }
            if (mul3 < y && !visited[mul3])
            {
                visited[mul3] = true;
                queue.Enqueue((mul3, count));
            }
            if (addN < y && !visited[addN])
            {
                visited[addN] = true;
                queue.Enqueue((addN, count));
            }
        }

        return result;
    }
}