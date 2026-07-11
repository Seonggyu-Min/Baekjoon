using System;

public class Solution {
    public int solution(int price) {
            if (500_000 <= price) return (int)(price * 0.8f);
            else if (300_000 <= price) return (int)(price * 0.9f);
            else if (100_000 <= price) return (int)(price * 0.95f);
            else return price;
    }
}