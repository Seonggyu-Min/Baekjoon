public class Program
{
    static void Main(string[] args)
    {
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());

        List<int> primes = new();

        for (int i = min; i <= max; i++)
        {
            if (CheckPrime(i))
            {
                primes.Add(i);
            }
        }

        if (primes.Count > 0)
        {
            Console.WriteLine(primes.Sum());
            Console.WriteLine(primes[0]);
        }
        else
        {
            Console.WriteLine(-1);
        }
    }

    private static bool CheckPrime(int prime)
    {
        if (prime == 1)
        {
            return false;
        }

        for (int i = 2; i <= (int)Math.Sqrt(prime); i++)
        {
            if (prime % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}