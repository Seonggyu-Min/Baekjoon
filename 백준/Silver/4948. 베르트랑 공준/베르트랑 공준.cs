public class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            int input = int.Parse(Console.ReadLine());
            if (input == 0) break;

            int count = 0;
            for (int i = input + 1; i <= input * 2; i++)
            {
                if (IsPrime(i)) count++;
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