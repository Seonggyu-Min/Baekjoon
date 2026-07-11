using System;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        int[] arr = new int[num_list.Length - (n - 1)];

        int count = 0;
        for (int i = n - 1; i < num_list.Length; i++)
        {
            arr[count++] = num_list[i];
        }

        return arr;
    }
}