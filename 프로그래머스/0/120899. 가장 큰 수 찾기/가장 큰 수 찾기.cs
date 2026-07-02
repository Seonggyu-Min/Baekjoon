using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] array) {
            var sorted = array.OrderByDescending(x => x).ToArray();
            var index = Array.IndexOf(array, sorted[0]);

            return new int[] { sorted[0], index };
    }
}