using System;
using System.Linq;

public class Solution {
    public int solution(int[] numbers) {
            var list = numbers.OrderByDescending(n => n).ToList();
            return list[0] * list[1];
    }
}