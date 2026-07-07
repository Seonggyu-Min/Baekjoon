using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] num_list) {
        var oddList = new List<int>();
        var evenList = new List<int>();

        foreach (var i in num_list)
        {
            if (i % 2 == 0) evenList.Add(i);
            else oddList.Add(i);
        }

        int oddSum = 0;
        int evenSum = 0;

        int multiplier = 1;

        for (int i = oddList.Count - 1; i >= 0; i--)
        {
            oddSum += oddList[i] * multiplier;
            multiplier *= 10;
        }

        multiplier = 1;

        for (int i = evenList.Count - 1; i >= 0; i--)
        {
            evenSum += evenList[i] * multiplier;
            multiplier *= 10;
        }

        return oddSum + evenSum;
    }
}