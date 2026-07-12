using System;
using System.Numerics;

public class Solution {
    public long solution(int n) {
        // 1. 브루트 포스로 2를 최대한 많이 사용한 경우부터 아예 안쓴 경우까지 순회
        // 최소 자리 수
        int min = n % 2 == 0 ? n / 2 : n / 2 + 1;
        // 최대 자리 수
        int max = n;

        long count = 0;
        for (int i = min; i <= max; i++)
        {
            // 2. 순회 중 하나의 경우의 수에서 동자순열 수 계산
            // i! / (1의 개수)! * (2의 개수)!

            // 1의 개수와 2의 개수 구하기
            int twoCount = n - i;
            int oneCount = i - twoCount;

            // 계산 과정이 팩토리얼이라 수가 너무 커질 수 있어서 약분
            long current = Combination(oneCount + twoCount, twoCount);

            count = (count + current) % 1_234_567;
        }

        // 3. 모든 순열의 수 합하여 반환
        return count;
    }
    
    long Combination(int totalCount, int selectedCount)
    {
        selectedCount = Math.Min(selectedCount, totalCount - selectedCount);
        var result = new BigInteger(1);

        for (int i = 1; i <= selectedCount; i++)
        {
            result *= totalCount - selectedCount + i;
            result /= i;
        }

        return (long)(result % 1_234_567);
    }
}