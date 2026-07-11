using System;

public class Solution {
    public int solution(int[] array, int n) {
        int count = 0;
        foreach (var i in array)
        {
            if (i == n) count++;
        }
        return count;
    }
}