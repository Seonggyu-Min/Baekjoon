using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        var set = new HashSet<int>(numbers);

        for (int i = 1; i <= 9; i++)
        {
            if (!set.Contains(i)) answer += i;
        }

        return answer;
    }
}