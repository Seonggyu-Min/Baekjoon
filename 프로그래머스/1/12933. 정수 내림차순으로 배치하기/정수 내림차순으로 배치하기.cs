using System;

public class Solution {
    public long solution(long n) {
        int totalDigit = 0;
        long temp = n;
        while (0 < temp)
        {
            temp /= 10;
            totalDigit++;
        }

        int[] arr = new int[totalDigit];

        for (int i = 0; i < totalDigit; i++)
        {
            arr[i] = (int)(n % 10);
            n /= 10;
        }

        Array.Sort(arr);

        long answer = 0;
        long digit = 1;

        foreach (var i in arr)
        {
            answer += i * digit;
            digit *= 10;
        }

        return answer;
    }
}