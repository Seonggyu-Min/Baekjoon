public class Solution {
    public string solution(string s) {
        var arr = s.Split(' ');

        int min = int.MaxValue;
        int max = int.MinValue;


        for (int i = 0; i < arr.Length; i++)
        {
            int parsed = int.Parse(arr[i]);

            if (parsed < min) min = parsed;
            if (parsed > max) max = parsed;
        }

        return $"{min} {max}";
    }
}