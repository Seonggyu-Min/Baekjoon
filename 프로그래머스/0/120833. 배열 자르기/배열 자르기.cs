using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers, int num1, int num2) {
            List<int> list = new();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (num1 <= i && i <= num2)
                {
                    list.Add(numbers[i]);
                }
            }

            return list.ToArray();
    }
}