using System;

public class Solution {
    public int[] solution(int brown, int yellow) {
        // 1. 넓이 구하기
        int area = brown + yellow;

        // 2. 넓이의 약수 쌍을 확인
        // 3. 약수 쌍에서 테두리 한 줄의 수가 brown과 일치하는 쌍 찾기
        for (int i = 2; i * i <= area; i++)
        {
            if (area % i != 0) continue;

            // i와 n이 한 쌍
            int n = area / i;

            if (brown == i * 2 + n * 2 - 4)
            {
                return i <= n ? [n, i] : [i, n];
            }
        }

        return [0, 0];
    }
}