using System;
using System.Text;

public class Solution {
    public int solution(int n, int k) {
        // n <= 1,000,000
        // 3 <= k <= 10
        // 3진수의 경우 13자리 수 까지 씀

        // k진수 변환
        int num = n;
        var sb = new StringBuilder();
        while (num != 0)
        {
            sb.Append(num % k);
            num /= k;
        }

        for (int i = 0, j = sb.Length - 1; i < j; i++, j--)
        {
            (sb[i], sb[j]) = (sb[j], sb[i]);
        }

        // 0을 제거하고 해당 단위로 분리
        var converted = sb.ToString();
        var splited = converted.Split('0', StringSplitOptions.RemoveEmptyEntries);

        // 분리된 수가 소수인지 검사
        int count = 0;
        foreach (var i in splited)
        {
            if (IsPrime(long.Parse(i)))
            {
                count++;
            }
        }

        return count;

        // O(√n)
        bool IsPrime(long n)
        {
            if (n < 2) return false;

            for (long i = 2; i <= n / i; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}