using System;

public class Solution {
    public int solution(int a, int b) {
        int digit1 = 10;
        int digit2 = 10;

        int temp = a;
        while (10 <= temp)
        {
            digit1 *= 10;
            temp /= 10;
        }
        temp = b;
        while (10 <= temp)
        {
            digit2 *= 10;
            temp /= 10;
        }

        return Math.Max(a * digit2 + b, b * digit1 + a);
    }
}