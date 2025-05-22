using System;

public class Solution {
    public int solution(int n) {
        if ((MathF.Sqrt(n)) % 1 == 0) return 1;
        else return 2;
    }
}