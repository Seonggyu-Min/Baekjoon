using System.Text;

public class Solution {
    public string solution(int n) {
        var sb = new StringBuilder(n);

        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0) sb.Append('수');
            else sb.Append('박');
        }

        return sb.ToString();
    }
}