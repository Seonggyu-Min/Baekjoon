using System.Linq;

public class Solution {
    public int[] solution(int[] arr) {
       if (arr.Length == 1) return [-1];

       int min = int.MaxValue;

       for (int i = 0; i < arr.Length; i++)
       {
           if (arr[i] < min) min = arr[i];
       }

       return arr.Where(i => min < i).ToArray();
    }
}