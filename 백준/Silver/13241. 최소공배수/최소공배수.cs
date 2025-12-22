public class Program
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split();

        int a = int.Parse(inputs[0]);
        int b = int.Parse(inputs[1]);

        Console.WriteLine(LCM(a, b));
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

    static long LCM(int a, int b)
    {
        return ((long)a * b) / GCD(a, b);
    }
}