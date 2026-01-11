public class Program
{
    static void Main(string[] args)
    {
        string[] input1 = Console.ReadLine().Split();
        string[] input2 = Console.ReadLine().Split();

        int numerator1 = int.Parse(input1[0]);
        int denominator1 = int.Parse(input1[1]);

        int numerator2 = int.Parse(input2[0]);
        int denominator2 = int.Parse(input2[1]);

        int multipliedNumerator = numerator1 * denominator2 + denominator1 * numerator2;
        int multipliedDenominator = denominator1 * denominator2;

        int divider = GCD(multipliedNumerator, multipliedDenominator);

        int finalNumerator = multipliedNumerator / divider;
        int finalDenominator = multipliedDenominator / divider;

        Console.WriteLine($"{finalNumerator} {finalDenominator}");
    }


    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int r = a % b;
            a = b;
            b = r;
        }
        return a;
    }
}