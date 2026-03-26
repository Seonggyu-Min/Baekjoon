public class Program
{
    static void Main(string[] args)
    {
        int testCase = int.Parse(Console.ReadLine()!);
        bool[] primeArr = new bool[1_000_001];

        for (int i = 0; i < primeArr.Length; i++)
        {
            primeArr[i] = IsPrime(i);
        }

        for (int i = 0; i < testCase; i++)
        {
            int n = int.Parse(Console.ReadLine()!);
            int count = 0;

            for (int j = 0; j <= n / 2; j++)
            {
                if (primeArr[j] && primeArr[n - j]) count++;
            }

            Console.WriteLine(count);
        }
    }

    static bool IsPrime(long number)
    {
        if (number < 2) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        long sqrt = (long)Math.Sqrt(number);
        for (long i = 3; i <= sqrt; i += 2)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}