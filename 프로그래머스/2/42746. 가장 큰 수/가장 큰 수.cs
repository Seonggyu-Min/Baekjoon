using System;
using System.Linq;
using System.Text;

public class Solution {
    public string solution(int[] numbers) {
        // 1 <= numbers.Length <= 100,000
        // 0 <= numbers 원소 <= 1,000

        // 정렬할 때 커지는 수를 왼쪽에 두기
        var strings = numbers.Select(x => x.ToString()).ToArray();

        // O(n log n)
        Array.Sort(strings, (a, b) =>
        {
            var aPlusB = a + b;
            var bPlusA = b + a;

            return bPlusA.CompareTo(aPlusB);
        });

        // 정렬했는데도 0이 앞에 오면 숫자 0이니 0반환
        if (strings[0] == "0")
        {
            return "0";
        }

        var sb = new StringBuilder();
        foreach (var s in strings)
        {
            sb.Append(s);
        }

        return sb.ToString();
    }
}