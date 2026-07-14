using System;

class Solution
{
    public int solution(int n, int a, int b)
    {
        int count = 0;
        while (true)
        {
            if (a == b) break;

            if (a % 2 == 0) a /= 2;
            else a = a / 2 + 1;

            if (b % 2 == 0) b /= 2;
            else b = b / 2 + 1;

            count++;
        }

        return count;
    }
}