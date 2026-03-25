public class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');

        int greater = int.Parse(input[0]);
        int less = int.Parse(input[1]);

        for (int i = greater; i <= less; i++)
        {
            if (IsPrime(i)) Console.WriteLine(i);
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