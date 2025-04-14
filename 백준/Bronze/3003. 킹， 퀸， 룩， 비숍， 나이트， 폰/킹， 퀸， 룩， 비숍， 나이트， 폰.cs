public class Program
{
    static void Main(string[] args)
    {
        string[] s = Console.ReadLine().Split();
        
        int k = int.Parse(s[0]);
        int q = int.Parse(s[1]);
        int r = int.Parse(s[2]);
        int b = int.Parse(s[3]);
        int kn = int.Parse(s[4]);
        int p = int.Parse(s[5]);

        Console.Write($"{1 - k} ");
        Console.Write($"{1 - q} ");
        Console.Write($"{2 - r} ");
        Console.Write($"{2 - b} ");
        Console.Write($"{2 - kn} ");
        Console.Write($"{8 - p}");
    }
}