using System;
using System.Text;

public class Solution {
    public long[] solution(long[] numbers) {
        // 1 <= numbers.Length <= 100,000
        // 0 <= numbers 원소 <= 10^15 == 1,000,000,000,000,000

        // 짝수일 때는 맨 오른쪽 비트가 0
        // 따라서, 그 비트만 1로 바꾸면 +1로 해당 수보다 큰 수 중 가장 작음

        // 홀수일 때는 오른쪽에서부터 연속된 1이 끝나고 나온 0을 1로 변환
        // 그리고 그 오른쪽 1을 0으로 변환
        // 즉, 키울 수 있는 최소 수를 더하고 그 중 내릴 수 있는 최대 수를 빼기

        var result = new long[numbers.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            var number = numbers[i];

            var binary = Convert.ToString(number, 2);
            var charArray = new char[number % 2 == 0 ? binary.Length : binary.Length + 1];

            if (number % 2 == 0)
            {
                for (int j = 0; j < charArray.Length; j++)
                {
                    charArray[j] = j == charArray.Length - 1 ? '1' : binary[j];
                }
            }
            else
            {
                bool hasMetZero = false;

                for (int j = charArray.Length - 1; j >= 0; j--)
                {
                    if (j == charArray.Length - 1)
                    {
                        binary = $"{0}{binary}";
                    }

                    if (binary[j] == '0' && !hasMetZero)
                    {
                        charArray[j] = '1';
                        charArray[j + 1] = '0';

                        hasMetZero = true;
                    }
                    else
                    {
                        charArray[j] = binary[j];
                    }
                }
            }

            var sb = new StringBuilder(charArray.Length);
            foreach (var c in charArray)
            {
                sb.Append(c);
            }

            var @decimal = Convert.ToInt64(sb.ToString(), 2);
            result[i] = @decimal;
        }

        return result;
    }
}