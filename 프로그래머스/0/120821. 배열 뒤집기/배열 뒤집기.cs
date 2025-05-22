using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = num_list.Reverse().ToArray();
        return answer;
    }
}