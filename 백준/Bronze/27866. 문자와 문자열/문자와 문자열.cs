internal class Program
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        int i = int.Parse(Console.ReadLine());
        Console.WriteLine(s.Substring(i - 1, 1));
    }
}