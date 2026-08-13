using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] queue1, int[] queue2) {
                // 1 <= queue1.Length, queue2.Length <= 300,000
        // 1 <= queue1 queue2 원소 <= 10^9 == 1,000,000,000
        // 최대 sum = 3 x 10^14 > int

        // 두 Queue를 만들고
        // 둘 중 큰 것이 있다면 옮기기 반복
        // 두 Queue 중 하나의 Queue라도 모든 원소가 한 번씩 Dequeue되었다면 -1 반환
        // 혹은 하나의 Queue라도 Count = 0이면 -1 반환

        var firstQueue = new Queue<int>(queue1);
        var secondQueue = new Queue<int>(queue2);

        long firstSum = queue1.Sum(x => (long)x);
        long secondSum = queue2.Sum(x => (long)x);

        long totalSum = firstSum + secondSum;

        // 전체 합이 홀수면 동등하게 나눠질 수 없음
        if (totalSum % 2 == 1)
        {
            return -1;
        }

        int count = 0;
        int limit = (queue1.Length + queue2.Length) * 2;

        // 종료 조건: 각 Queue가 한 바퀴씩 전부 돌아봤다면
        while (count < limit)
        {
            // 종료 조건: 서로의 합이 같음
            if (firstSum == secondSum)
            {
                return count;
            }

            if (firstSum < secondSum)
            {
                var value = secondQueue.Dequeue();

                secondSum -= value;
                firstSum += value;

                firstQueue.Enqueue(value);
            }
            else
            {
                var value = firstQueue.Dequeue();

                firstSum -= value;
                secondSum += value;

                secondQueue.Enqueue(value);
            }

            count++;
        }

        return -1;
    }
}