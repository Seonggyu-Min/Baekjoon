using System;

public class Solution {
    public int solution(int[] citations) {
        Array.Sort(citations, (a, b) => b.CompareTo(a));

        int idx = 0;
        for (int i = 0; i < citations.Length; i++)
        {
            // citations[i]: 논문 인용 수
            // i + 1: 현재까지 확인한 논문의 개수
            if (citations[i] >= i + 1)
            {
                idx = i + 1;
            }
        }

        return idx;
    }
}