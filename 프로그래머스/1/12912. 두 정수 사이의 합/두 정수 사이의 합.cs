public class Solution {
    public long solution(int a, int b) {
        long sum = 0;
        int small = a <= b ? a : b;
        int big = a <= b ? b : a;
        for (int i = small; i <= big; i++)
        {
            sum += i;
        }
        return sum;
    }
}