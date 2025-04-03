internal class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            string s = Console.ReadLine();
            Console.WriteLine($"{s[0]}{s[s.Length - 1]}");
        }
    }
}