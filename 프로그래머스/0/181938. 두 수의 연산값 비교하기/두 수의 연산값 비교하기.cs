using System;

public class Solution {
    public int solution(int a, int b) {
        var sum = int.Parse($"{a}{b}");
        var mul = 2 * a * b;

        return mul <= sum ? sum : mul;
    }
}