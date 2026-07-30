using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] priorities, int location) {
        // dictionary에 인덱스, 우선순위 기록
        var dict = new Dictionary<int/*location*/, int /*priority*/>();

        // dict 초기화
        for (int i = 0; i < priorities.Length; i++)
        {
            dict[i] = priorities[i];
        }

        var executed = new Dictionary<int/*location*/, int/*executed order*/>();
        // 실행된 순서
        var order = 0;
        // 반복문 안에서 전에 빠진 프로세스의 인덱스를 기억해 다음에 이어서 하도록 처리
        var locationIndex = -1;
        var dictCount = dict.Count;

        // n <= 100, O(n^2)
        while (executed.Count != dictCount)
        {
            // 최댓값 찾기
            var maxValue = dict.Values.Max();

            var iteratingIndex = 0;
            for (int i = 0; i < dictCount; i++)
            {
                iteratingIndex = (i + locationIndex + 1) % dictCount;
                if (dict.TryGetValue(iteratingIndex, out var value))
                {
                    if (value == maxValue)
                    {
                        executed[iteratingIndex] = order;
                        order++;
                        locationIndex = iteratingIndex;
                        dict.Remove(locationIndex);
                        break;
                    }
                }
            }
        }

        return executed[location] + 1;
    }
}