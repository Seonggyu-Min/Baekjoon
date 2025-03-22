class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int n = int.Parse(input);

        for (int i = 1; i < 10; i++)
        {
            System.Console.WriteLine($"{n} * {i} = {n * i}");
        }
    } 
}