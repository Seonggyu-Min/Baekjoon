using System;

public class Solution {
    public int[] solution(int money) {
        
            int count = 0;
            while (5500 <= money)
            {
                money -= 5500;
                count++;
            }

            return new int[] { count, money };
    }
}