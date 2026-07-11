using System;

public class Solution {
    public int solution(int[] num_list) {
        int multi = 1;
        int sum = 0;
        int sqr = 0;

        foreach (var i in num_list)
        {
            multi *= i;
            sum += i;
        }

        sqr = sum * sum;

        return multi < sqr ? 1 : 0;
    }
}