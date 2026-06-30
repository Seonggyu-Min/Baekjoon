using System;

public class Solution {
    public int solution(string my_string) {
          int answer = 0;

          foreach (var c in my_string)
          {
              if ('1' <= c && c <= '9')
              {
                  answer += c - '0';
              }
          }

          return answer;
    }
}