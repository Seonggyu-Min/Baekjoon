public class Solution {
    public string solution(string s) {
        var arr = new char[s.Length];
        bool isStart = true;

        for (int i = 0; i < s.Length; i++)
        {
            arr[i] = isStart ? char.ToUpperInvariant(s[i]) : char.ToLowerInvariant(s[i]);
            isStart = s[i] == ' ' ? true : false;
        }

        return new string(arr);
    }
}