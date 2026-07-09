public class Solution {
    public string solution(string s) => s.Length % 2 == 0 ? $"{s[s.Length / 2 - 1]}{s[s.Length / 2]}" : s[s.Length / 2].ToString();

}