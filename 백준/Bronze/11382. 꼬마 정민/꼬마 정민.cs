internal class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        string[] sInpit = input.Split(' ');

        long numA = long.Parse(sInpit[0]);
        long numB = long.Parse(sInpit[1]);
        long numC = long.Parse(sInpit[2]);

        Console.WriteLine(numA + numB + numC);
    }
}