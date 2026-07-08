using System;

public class Solution {
    public int solution(int n) {
        int min = int.MaxValue;

        for (int i = n - 1; i > 0; i--)
        {
            if (n % i == 1) min = i;
        }

        return min;
    }
}