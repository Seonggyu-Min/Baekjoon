public class Program
{
    static void Main(string[] args)
    {
        string[] s = Console.ReadLine().Split();

        int a = int.Parse(s[0]);
        int b = int.Parse(s[1]);

        int c = a % 10 * 100 + a / 10 % 10 * 10 + a / 100;
        int d = b % 10 * 100 + b / 10 % 10 * 10 + b / 100;

        
        if (c > d)
            Console.WriteLine(c);
        else if (d > c)
            Console.WriteLine(d);
    }
}