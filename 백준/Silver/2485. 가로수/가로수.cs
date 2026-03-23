public class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        var hashSet = new HashSet<int>();
        int prev = 0;
        int first = 0;

        for (int i = 0; i < n; i++)
        {
            int input = int.Parse(Console.ReadLine());

            if (i == 0) first = input;
            if (prev != 0) hashSet.Add(input - prev);

            prev = input;
        }

        int gcd = GCDOfSet(hashSet);

        int count = 1;
        int sum = first;
        while (true)
        {
            sum += gcd;
            count++;

            if (sum == prev) break;
        }

        Console.WriteLine(count - n);
    }


    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int r = a % b;
            a = b;
            b = r;
        }
        return Math.Abs(a);
    }

    static int GCDOfSet(HashSet<int> hashSet)
    {
        int result = 0;

        foreach (var i in hashSet)
        {
            if (result == 0)
            {
                result = i;
                continue;
            }

            result = GCD(result, i);
        }

        return result;
    }
}
