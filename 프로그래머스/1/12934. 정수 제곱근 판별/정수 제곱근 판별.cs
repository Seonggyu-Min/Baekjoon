using System;

public class Solution {
    public long solution(long n) {
        var sqrt = (long)Math.Sqrt(n);
        if (sqrt * sqrt == n)
        {
            return (sqrt + 1) * (sqrt + 1);
        }
        else
        {
            return -1;
        }
    }
}