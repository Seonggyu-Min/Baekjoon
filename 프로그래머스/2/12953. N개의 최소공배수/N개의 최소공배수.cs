public class Solution {
    public int solution(int[] arr) {
        int lcm = 0;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (i == 0)
            {
                lcm = LCM(arr[i], arr[i + 1]);
            }
            else
            {
                lcm = LCM(lcm, arr[i + 1]);
            }
        }

        return lcm;
    }
    
    int GCD(int a, int b)
    {
        while (b != 0)
        {
            int r = a % b;
            a = b;
            b = r;
        }

        return a;
    }

    int LCM(int a, int b)
    {
        return (a * b) / GCD(a, b);
    }
}