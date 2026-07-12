using System.Numerics;

public class Solution {
    public int solution(int n) {
        // 1. 피보나치 함수 만들기
        BigInteger Fibonacci(int n)
        {
            var prev = new BigInteger(0);
            var cur = new BigInteger(1);

            for (int i = 2; i <= n; i++)
            {
                var next = prev + cur;
                prev = cur;
                cur = next;
            }

            return cur;
        }

        // 2. 해당 함수로 F(n) 구하기
        var value = Fibonacci(n);

        // 3. 해당 값을 1234567로 나눈 나머지 return
        return (int)(value % 1_234_567);
    }
}