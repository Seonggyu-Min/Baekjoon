class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] s = input.Split(' ');

        int a = int.Parse(s[0]);
        int b = int.Parse(s[1]);
        int c = int.Parse(s[2]);

        if (a == b && b == c)
            System.Console.WriteLine(10000 + a * 1000);
        else if (a == b)
            System.Console.WriteLine(1000 + a * 100);
        else if (b == c || a == c)
            System.Console.WriteLine(1000 + c * 100);
        else
            System.Console.WriteLine(CheckBiggest(a, b, c) * 100);
    }

    static int CheckBiggest(int a, int b, int c)
    {
        if (a >= b)
        {
            if (a >= c)
                return a;
            else
                return c;
        }
        else
        {
            if (b >= c)
                return b;
            else
                return c;
        }
    }
}
