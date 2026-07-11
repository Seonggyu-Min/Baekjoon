using System;

public class Solution {
    public int[] solution(string s) {
        int repeatCount = 0;
        int zeroRemovedCount = 0;
        while (s != "1")
        {
            // 1. 0을 제거한 문자열 생성 및 제거한 0 개수 카운트
            int zeroCount = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '0') zeroCount++;
            }

            zeroRemovedCount += zeroCount;

            // 2. zeroCount를 이진법으로 변환
            string binary = "";
            int afterRemoveLength = s.Length - zeroCount;
            while (0 < afterRemoveLength)
            {
                binary = $"{afterRemoveLength % 2}{binary}";
                afterRemoveLength /= 2;
            }

            s = binary;

            repeatCount++;
        }
        // 3. 문자열이 1이 될 때까지 반복

        return [repeatCount, zeroRemovedCount];
    }
}