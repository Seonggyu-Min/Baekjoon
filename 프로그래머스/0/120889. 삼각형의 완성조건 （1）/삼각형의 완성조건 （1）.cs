using System;
using System.Linq;

public class Solution {
    public int solution(int[] sides) {
            var sorted = sides.OrderBy(x => x).ToArray();

            if (sorted[2] < sorted[0] + sorted[1]) return 1;
            else return 2;
    }
}