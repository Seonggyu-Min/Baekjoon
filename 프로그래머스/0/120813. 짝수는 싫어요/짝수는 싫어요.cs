using System;

public class Solution {
    public int[] solution(int n) {
        int count = (n + 1) / 2;
        int[] answer = new int[count];

        int value = 1;

        for (int i = 0; i < count; i++)
        {
            answer[i] = value;
            value += 2;
        }

        return answer;
    }
}