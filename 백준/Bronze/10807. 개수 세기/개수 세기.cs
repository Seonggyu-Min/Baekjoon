internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string[] s = Console.ReadLine().Split(' ');

        string v = Console.ReadLine();

        int count = 0;

        for (int i = 0; i < n; i++)
        {
            if (s[i] == v)
                count++;
        }
        Console.WriteLine(count);
    }
}