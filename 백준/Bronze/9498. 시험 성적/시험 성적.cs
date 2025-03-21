class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int score = int.Parse(input);

        if (score >= 90)
        System.Console.WriteLine('A');
        else if (score >= 80)
        System.Console.WriteLine('B');
        else if (score >= 70)
        System.Console.WriteLine('C');
        else if (score >= 60)
        System.Console.WriteLine('D');
        else
        System.Console.WriteLine('F');
    }
}
