using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] numbers) => numbers.Select(x => x * 2).ToArray();
}