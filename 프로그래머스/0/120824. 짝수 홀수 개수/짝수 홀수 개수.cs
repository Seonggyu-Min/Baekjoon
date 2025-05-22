using System;

public class Solution {
    public int[] solution(int[] num_list) {
            int even = 0;
            int odd = 0;

            for (int i = 0; i < num_list.Length; i++)
            {
                if (num_list[i] % 2 == 0) even++;
                else odd++;
            }

            int[] answer = new int[] { even, odd };
            return answer;
    }
}