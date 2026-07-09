using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long priceL = price;
        long countL = count;

        var total = (priceL + priceL * countL) * countL / 2;

        return money - total < 0 ? total - money : 0;
    }
}