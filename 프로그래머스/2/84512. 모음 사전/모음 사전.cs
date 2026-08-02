using System;

public class Solution {
    public int solution(string word) {
        // 1 <= word.Length <= 5
        // 완전 탐색으로도 5^0 + 5^1 + ... + 5^5 = 3905로 충분히 가능할 것 같음
        // 근데 규칙을 찾으면 O(5^n) 대신 O(n) 혹은 O(1)으로도 찾을 수 있을 것 같음

        // 각 자리 수에서 다음 알파벳으로 넘기는 규칙
        // 1: 1 + 5 + 25 + 125 + 625 = 781
        // 2: 1 + 5 + 25 + 125 = 156
        // 3: 1 + 5 + 25 = 31
        // 4: 1 + 5 = 6
        // 5: 1

        // 현재 word가 몇 자리인지에 따라 추가
        // n자리: + n

        int answer = word.Length;
        for (int i = 0; i < word.Length; i++)
        {
            var digit = 5 - i;
            var add = GetNextPageValue(word[i], digit);

            answer += add;
        }

        return answer;

        int GetNextPageValue(char c, int digit)
        {
            int sum = 0;

            for (int i = 0; i < digit; i++)
            {
                sum += (int)Math.Pow(5, i) * GetCharMultiplier(c);
            }

            return sum;
        }

        int GetCharMultiplier(char c)
        {
            return c switch
            {
                'A' => 0,
                'E' => 1,
                'I' => 2,
                'O' => 3,
                'U' => 4,
            };
        }
    }
}