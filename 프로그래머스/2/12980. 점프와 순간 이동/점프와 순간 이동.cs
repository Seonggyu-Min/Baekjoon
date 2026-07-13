using System;

class Solution
{
    public int solution(int n)
    {
        // n에서 0으로 가는 것으로 생각

        // 직전 n이 짝수라면 2로 나누고, 순간이동으로 왔다고 가정
        // 직전 n이 홀수라면 -1하고 점프로 왔다고 가정 (배터리 + 1)

        int count = 0;
        while (n != 0)
        {
            if (n % 2 == 0)
            {
                n /= 2;
            }
            else
            {
                n--;
                count++;
            }
        }

        return count;
    }
}