using System;

public class Solution {
    public int[] solution(string[] strlist) {
            var ans = new int[strlist.Length];

            for (int i = 0; i < strlist.Length; i++)
            {
                ans[i] = strlist[i].Length;
            }

            return ans;
    }
}