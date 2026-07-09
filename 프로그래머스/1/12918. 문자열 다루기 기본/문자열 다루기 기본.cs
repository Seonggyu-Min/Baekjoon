public class Solution {
    public bool solution(string s) => int.TryParse(s, out var i) && (4 == s.Length || s.Length == 6);
}