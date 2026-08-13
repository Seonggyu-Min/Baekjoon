using System;

public class Solution {
    public long[] solution(long[] numbers) {
        // 1 <= numbers.Length <= 100,000
        // 0 <= numbers 원소 <= 10^15 == 1,000,000,000,000,000

        // 짝수일 때는 맨 오른쪽 비트가 0
        // 따라서, 그 비트만 1로 바꾸면 +1로 해당 수보다 큰 수 중 가장 작음

        // 홀수일 때는 오른쪽에서부터 연속된 1이 끝나고 나온 0을 1로 변환
        // 그리고 그 오른쪽 1을 0으로 변환
        // 즉, 키울 수 있는 최소 수를 더하고 그 중 내릴 수 있는 최대 수를 빼기

        var result = new long[numbers.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            var number = numbers[i];

            // 짝수라면 마지막 비트만 1로 변환
            if ((number & 1) == 0)
            {
                result[i] = number + 1;
            }
            // 홀수라면
            else
            {
                // 비트를 왼쪽으로 밀면서 첫 0 찾기
                var bit = 1L;
                while ((number & bit) != 0)
                {
                    bit <<= 1;
                }

                // 첫 0을 1로 바꾸고 (number + bit)
                // 바로 오른쪽 1을 0으로 (- (bit >> 1))
                result[i] = number + bit - (bit >> 1);
            }
        }

        return result;
    }
}