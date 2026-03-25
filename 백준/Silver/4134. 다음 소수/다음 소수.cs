public class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            long input = long.Parse(Console.ReadLine());

            if (input <= 2)
            {
                Console.WriteLine(2);
                continue;
            }

            if (input % 2 == 0)
            {
                input++;
            }

            while (!IsPrime(input))
            {
                input += 2;
            }

            Console.WriteLine(input);
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