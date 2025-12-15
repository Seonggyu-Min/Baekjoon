public class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int start = Math.Max(1, n - 63);
        int answer = 0;

        for (int i = start; i <= n; i++)
        {
            if (Compute(i) == n)
            {
                answer = i;
                break;
            }
        }

        if (answer == 0)
            Console.WriteLine(0);
        else
            Console.WriteLine(answer);
    }

    static int Compute(int x)
    {
        int sum = x;

        while (x > 0)
        {
            sum += x % 10;
            x /= 10;
        }

        return sum;
    }
}