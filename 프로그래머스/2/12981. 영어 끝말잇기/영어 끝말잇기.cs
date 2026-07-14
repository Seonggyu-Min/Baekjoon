using System;
using System.Collections.Generic;

class Solution
{
    public int[] solution(int n, string[] words)
    {
        // 0. 탈락 조건
        // 중복, 전의 끝 단어와 현재 시작 단어 불일치

        // 0-1 중복은 Set으로
        // 0-2 전의 끝 단어 비교는 인덱스 -1로
        var set = new HashSet<string>() { words[0] };

        // 1. words 순회하며 int current = n++ 및 mod n연산으로 돌려가기
        int repeat = 1; // 몇 바퀴 돌았는지
        int current = 0; // 현재 몇 번째 사람인지

        for (int i = 1; i < words.Length; i++)
        {
            // 2. 각 순회 시 int repeat++, 현재 몇 번째 사람인지 기록
            if (i % n == 0) repeat++;
            current = (current + 1) % n;

            if (set.Contains(words[i]))
            {
                break;
            }

            var beforeEndWord = words[i - 1][words[i - 1].Length - 1];
            var curFirstWord = words[i][0];

            if (beforeEndWord != curFirstWord)
            {
                break;
            }

            set.Add(words[i]);

            // 모두 순회했는데 탈락하지 않았으면 0,0 반환
            if (i == words.Length - 1) return [0, 0];
        }

        // 3. 0-1, 0-2 조건 검사하며 실패 시 current와 repeat 반환
        return [current + 1, repeat];
    }
}