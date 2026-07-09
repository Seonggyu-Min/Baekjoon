using System.Text;

public class Solution {
    public string solution(string phone_number) {
        var sb = new StringBuilder(phone_number.Length);

        for (int i = 0; i < phone_number.Length; i++)
        {
            if (i < phone_number.Length - 4) sb.Append('*');
            else sb.Append(phone_number[i]);
        }

        return sb.ToString();
    }
}