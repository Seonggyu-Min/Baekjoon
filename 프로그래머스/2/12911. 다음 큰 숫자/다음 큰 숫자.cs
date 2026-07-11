using System;

class Solution 
{
    public int solution(int n) 
    {
        // 1. n의 2진수에서의 1의 개수 확인
        var s = Convert.ToString(n, 2);
        int onwCount = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '1') onwCount++;
        }

        // 2. n을 1씩 증가시키면서 1의 개수가 같은 10진수 찾기
        var binary = string.Empty;

        while (true)
        {
            n++;
            int oneCount2 = 0;
            binary = Convert.ToString(n, 2);

            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1') oneCount2++;
            }

            if (onwCount == oneCount2) break;
        }

        return n;
    }
}