using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string message, int[,] spoiler_ranges) {
        // 스포일러 판별용 HashSet 구성
        var spoilerIndexSet = new HashSet<int>();
        for (int row = 0; row < spoiler_ranges.GetLength(0); row++)
        {
            for (int col = 0; col < spoiler_ranges.GetLength(1); col += 2)
            {
                for (int i = spoiler_ranges[row, col]; i <= spoiler_ranges[row, col + 1]; i++)
                {
                    spoilerIndexSet.Add(i);
                }
            }
        }

        // 공개 단어, 스포일러 단어 구성
        var openSet = new HashSet<string>();
        var spoilerSet = new HashSet<string>();

        int start = 0;
        int end = 0;

        for (int i = 0; i < message.Length; i++)
        {
            if (message[i] == ' ')
            {
                if (i == 0)
                {
                    start = 1;
                    continue;
                }

                end = i - 1;

                Distribute(start, end);

                start = i + 1;
            }

            // 맨 마지막일 때 처리
            if (i == message.Length - 1)
            {
                end = i;
                Distribute(start, end);
            }
        }

        // 중요한 단어 판별
        var importantSet = new HashSet<string>();

        foreach (var word in spoilerSet)
        {
            // 1. 공개 단어에 있는지 판별
            if (openSet.Contains(word))
            {
                continue;
            }
            // 2. 없으면, 이미 중요한 단어에 있는지 판별
            if (importantSet.Contains(word))
            {
                continue;
            }
            // 3. 여기까지 없으면 Set에 넣어 중복 제거 및 삽입
            importantSet.Add(word);
        }

        return importantSet.Count;


        void Distribute(int start, int end)
        {
            bool isSpoiler = false;
            for (int j = start; j <= end; j++)
            {
                if (spoilerIndexSet.Contains(j))
                {
                    isSpoiler = true;
                    break;
                }
            }

            if (isSpoiler)
            {
                spoilerSet.Add(message.Substring(start, end - start + 1));
            }
            else
            {
                openSet.Add(message.Substring(start, end - start + 1));
            }
        }
    }
}