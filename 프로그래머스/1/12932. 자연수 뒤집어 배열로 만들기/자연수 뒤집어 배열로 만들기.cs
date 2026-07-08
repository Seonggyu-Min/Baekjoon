using System;

public class Solution {
    public int[] solution(long n) {
        int totalDigit = 0;
        long temp = n;
        while (0 < temp)
        {
            temp /= 10;
            totalDigit++;
        }

        int[] answer = new int[totalDigit];

        for (int i = totalDigit - 1; i >= 0; i--)
        {
            answer[i] = (int)(n % 10);
            n /= 10;
        }

        Array.Reverse(answer);

        return answer;
    }
}