class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int score = int.Parse(input);

        if ((score % 4 == 0) && (score % 100 != 0) || (score % 400 == 0))
        System.Console.WriteLine('1');
        else
        System.Console.WriteLine('0');
    }
}