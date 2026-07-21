using System;

public class Solution {
    public int[] solution(int n, long left, long right) {
        // 1. 출력에 필요한 배열 크기 만들기
        var arr = new int[right - left + 1];

        // 2. 배열에 들어갈 것을 역산
        for (long i = left; i <= right; i++)
        {
            long row = i / n;
            long col = i % n;
            
            long max = Math.Max(row, col);
            arr[i - left] = (int)max + 1;
        }

        return arr;
    }
}