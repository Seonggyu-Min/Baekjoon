class Program
{
    static void Main(string[] args)
    {
        string line;
        while ((line = Console.ReadLine()) != null)
        {
            string[] s = line.Split();
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            Console.WriteLine(a + b);
        }
    }
}