using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n, int[] numlist) {
            var list = new List<int>(numlist);

            for (int i = numlist.Length - 1; i >= 0; i--)
            {
                if (numlist[i] % n != 0)
                {
                    list.RemoveAt(i);
                }
            }

            return list.ToArray();
    }
}