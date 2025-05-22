using System;

public class Solution {
    public double solution(int[] numbers) {
            double sum = 0;
            
            foreach (var num in numbers)
            {
                sum += num;
            }

            double answer = sum / numbers.Length;
            return answer;
    }
}