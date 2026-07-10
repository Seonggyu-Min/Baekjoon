using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string message, int[,] spoiler_ranges) {
        var spoilerIndexSet = new HashSet<int>();

        for (int row = 0; row < spoiler_ranges.GetLength(0); row++)
        {
            int rangeStart = spoiler_ranges[row, 0];
            int rangeEnd = spoiler_ranges[row, 1];

            for (int i = rangeStart; i <= rangeEnd; i++)
            {
                spoilerIndexSet.Add(i);
            }
        }

        var openSet = new HashSet<string>();
        var spoilerSet = new HashSet<string>();

        int wordStart = 0;

        for (int i = 0; i <= message.Length; i++)
        {
            bool isWordEnd = i == message.Length || message[i] == ' ';

            if (!isWordEnd)
            {
                continue;
            }

            int wordEnd = i - 1;
            bool isSpoiler = false;

            for (int j = wordStart; j <= wordEnd; j++)
            {
                if (spoilerIndexSet.Contains(j))
                {
                    isSpoiler = true;
                    break;
                }
            }

            string word = message.Substring(wordStart, wordEnd - wordStart + 1);

            if (isSpoiler)
            {
                spoilerSet.Add(word);
            }
            else
            {
                openSet.Add(word);
            }

            wordStart = i + 1;
        }

        
        int answer = 0;

        foreach (string word in spoilerSet)
        {
            if (!openSet.Contains(word))
            {
                answer++;
            }
        }

        return answer;
    }
}