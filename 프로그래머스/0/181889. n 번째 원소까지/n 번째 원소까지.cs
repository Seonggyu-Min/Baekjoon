using System;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        var arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = num_list[i];
        }

        return arr;
    }
}