using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
          var set = new HashSet<int>();

          for (int i = 1; i * i <= n; i++)
          {
              if (n % i != 0) continue;
              set.Add(i);
              set.Add(n / i);
          }

          return set.OrderBy(x => x).ToArray();
    }
}