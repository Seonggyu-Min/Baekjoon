using System;
using System.Linq;

public class Solution {
    public int solution(int[] array) {
        var sorted = array.OrderBy(x => x).ToArray();
        return sorted[sorted.Length / 2];
    }
}