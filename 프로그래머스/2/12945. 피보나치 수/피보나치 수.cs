public class Solution {
    public int solution(int n) {
        int prev = 0;
        int cur = 1;

        for (int i = 2; i <= n; i++)
        {
            int next = (prev + cur) % 1_234_567;
            prev = cur;
            cur = next;
        }

        return cur;
    }
}