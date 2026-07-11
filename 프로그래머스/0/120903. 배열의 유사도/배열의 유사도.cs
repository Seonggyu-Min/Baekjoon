using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[] s1, string[] s2) {
            int count = 0;
            var set = new HashSet<string>(s1);

            foreach (var s in s2)
            {
                if (set.Contains(s)) count++;
            }
            
            return count;
    }
}