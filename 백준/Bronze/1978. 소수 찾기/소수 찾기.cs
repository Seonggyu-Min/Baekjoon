public class Program
{
    static void Main(string[] args)
    {
        int _caseNum = int.Parse(Console.ReadLine());
        string[] _inputs = Console.ReadLine().Split();
        int _primeCount = 0;

        for (int i = 0; i < _caseNum; i++)
        {
            int _num = int.Parse(_inputs[i]);

            if (IsPrime(_num))
            {
                _primeCount++;
            }
        }

        Console.WriteLine(_primeCount);
    }

    private static bool IsPrime(int num)
    {
        if (num < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}