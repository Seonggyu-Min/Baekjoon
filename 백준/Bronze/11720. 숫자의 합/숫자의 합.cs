internal class Program
{
    static void Main(string[] args)
    {
        Console.ReadLine();
        string s = Console.ReadLine();
        int sum = 0;

        for (int i = 0; i < s.Length; i++)
        {
            sum += s[i] - '0';
        }
        Console.WriteLine(sum);
    }
}