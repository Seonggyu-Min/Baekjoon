using System;

public class Solution {
    public int solution(int num1, int num2) {
            var divided = (float)num1 / num2;
            return (int)(divided * 1000);
    }
}