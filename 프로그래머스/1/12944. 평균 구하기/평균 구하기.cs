public class Solution {
    public double solution(int[] arr) {
        double sum = 0;

        foreach (var i in arr) sum += i;

        var avr = sum / arr.Length;
        return avr;
    }
}