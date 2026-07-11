using System.Text;

public class Solution {
    public string solution(string s) {
        var sb = new StringBuilder(s.Length);
        bool isStart = true;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ')
            {
                isStart = true;
            }
            else
            {
                if (isStart && 'a' <= s[i] && s[i] <= 'z')
                {
                    sb.Append((char)(s[i] - 32));
                    isStart = false;
                    continue;
                }
                else if (!isStart && 'A' <= s[i] && s[i] <= 'Z')
                {
                    sb.Append((char)(s[i] + 32));
                    continue;
                }
                else
                {
                    isStart = false;
                }
            }

            sb.Append(s[i]);
        }

        return sb.ToString();
    }
}