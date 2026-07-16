using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[] want, int[] number, string[] discount) {
        var wishDict = new Dictionary<string, int>();
        for (int i = 0; i < want.Length; i++)
        {
            wishDict.Add(want[i], number[i]);
        }

        var cur = new Dictionary<string, int>();
        int day = 0;

        // 할인 날짜 순회하면서 확인
        for (int i = 0; i < discount.Length; i++)
        {
            // 우선 첫 10일 채우기
            if (i < 10)
            {
                if (cur.TryGetValue(discount[i], out var count))
                {
                    cur[discount[i]] = count + 1;
                }
                else
                {
                    cur[discount[i]] = 1;
                }

                if (i != 9) continue;
            }
            // 이후로는 10일 전 제거, 현재 날짜 추가
            else
            {
                cur[discount[i - 10]]--;

                if (cur.TryGetValue(discount[i], out var count))
                {
                    cur[discount[i]] = count + 1;
                }
                else
                {
                    cur[discount [i]] = 1;
                }
            }

            bool isEqual = true;
            // 원하는 상품 목록와 현재 목록이 일치하는지 확인
            foreach (var item in wishDict)
            {
                if (!cur.TryGetValue(item.Key, out var count) || count != item.Value)
                {
                    isEqual = false;
                    break;
                }
            }

            if (isEqual) day++;
        }

        return day;
    }
}