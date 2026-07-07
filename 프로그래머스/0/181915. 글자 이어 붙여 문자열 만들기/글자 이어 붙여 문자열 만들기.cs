using System;
using System.Text;

public class Solution {
    public string solution(string my_string, int[] index_list) {
        var sb = new StringBuilder(index_list.Length);
        
        foreach (var i in index_list)
        {
            sb.Append(my_string[i]);
        }

        return sb.ToString();
    }
}